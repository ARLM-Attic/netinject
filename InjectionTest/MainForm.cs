using ICSharpCode.Decompiler.Ast;
using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetInject.App
{
    public partial class MainForm : Form
    {
        private List<AssemblyDefinition> assemblies;

        public MainForm()
        {
            InitializeComponent();
            listProgrammingLanguage.SelectedIndex = 0;
            treeLoadedAssemblies.ImageList = ImageList;

            this.assemblies = new List<AssemblyDefinition>();
        }

        static ImageList imageList;
        private static ImageList ImageList
        {
            get
            {
                if (imageList == null)
                {
                    imageList = new ImageList();
                    imageList.Images.Add("ClassIcon", Resource.ClassIcon);
                    imageList.Images.Add("MethodIcon", Resource.MethodIcon);
                    imageList.Images.Add("AssemblyIcon", Resource.AssemblyIcon);
                    imageList.Images.Add("ReferenceIcon", Resource.ReferenceIcon);
                    imageList.Images.Add("ResourceIcon", Resource.ResourceIcon);
                    imageList.Images.Add("NamespaceIcon", Resource.NamespaceIcon);
                    imageList.Images.Add("PropertyIcon", Resource.PropertyIcon);
                    imageList.Images.Add("CSharpFileIcon", Resource.CSharpFileIcon);
                    imageList.Images.Add("CSharpProjectIcon", Resource.CSharpProjectIcon);
                }
                return imageList;
            }
        }

        private void menuItemAssemblyLoad_Click(object sender, EventArgs e)
        {
            if (loadAssemblyDialog.ShowDialog() == DialogResult.OK)
            {
                var file = new FileInfo(loadAssemblyDialog.FileName);
                LoadAssembly(file);
            }
        }

        private void UpdateTree()
        {
            treeLoadedAssemblies.BeginUpdate();

            foreach (var assembly in assemblies)
            {
                var assemblyNode = treeLoadedAssemblies.Nodes.Add(assembly.Name.Name);
                assemblyNode.ImageKey = "AssemblyIcon";
                assemblyNode.SelectedImageKey = "AssemblyIcon";
                assemblyNode.Tag = assembly;

                foreach (var module in assembly.Modules)
                {
                    var moduleNode = assemblyNode.Nodes.Add(module.Name);
                    moduleNode.ImageKey = "CSharpProjectIcon";
                    moduleNode.SelectedImageKey = "CSharpProjectIcon";

                    //var propertiesNode = moduleNode.Nodes.Add("Properties");
                    //propertiesNode.ImageKey = "PropertyIcon";
                    //propertiesNode.SelectedImageKey = "PropertyIcon";
                    //var assemblyInfoNode = propertiesNode.Nodes.Add("AssemblyInfo.cs");
                    //assemblyInfoNode.Tag = module;
                    //assemblyInfoNode.ImageKey = "CSharpFileIcon";
                    //assemblyInfoNode.SelectedImageKey = "CSharpFileIcon";

                    // References
                    var referencesNode = moduleNode.Nodes.Add("References");
                    referencesNode.ImageKey = "ReferenceIcon";
                    referencesNode.SelectedImageKey = "ReferenceIcon";

                    foreach (var referece in assembly.MainModule.AssemblyReferences)
                    {
                        var referenceNode = referencesNode.Nodes.Add(referece.Name);
                        referenceNode.ImageKey = "ReferenceIcon";
                        referenceNode.SelectedImageKey = "ReferenceIcon";
                    }

                    // Resources
                    var resourcesNode = moduleNode.Nodes.Add("Resources");
                    resourcesNode.ImageKey = "ResourceIcon";
                    resourcesNode.SelectedImageKey = "ResourceIcon";

                    foreach (var resource in assembly.MainModule.Resources)
                    {
                        var resourceNode = resourcesNode.Nodes.Add(resource.Name);
                        resourceNode.ImageKey = "ResourceIcon";
                        resourceNode.SelectedImageKey = "ResourceIcon";
                    }

                    var namespaceNodes = new Dictionary<string, TreeNode>();

                    // Types
                    foreach (var type in module.Types)
                    {
                        TreeNode namespaceNode = null;

                        // Namespace
                        if (namespaceNodes.ContainsKey(type.Namespace))
                        {
                            namespaceNode = namespaceNodes[type.Namespace];
                        }
                        else
                        {
                            string namespaceName = String.IsNullOrWhiteSpace(type.Namespace) ? "<Default namespace>" : type.Namespace;

                            namespaceNode = moduleNode.Nodes.Add(namespaceName);
                            namespaceNode.ImageKey = "NamespaceIcon";
                            namespaceNode.SelectedImageKey = "NamespaceIcon";

                            namespaceNodes[type.Namespace] = namespaceNode;
                        }

                        var typeNode = namespaceNode.Nodes.Add(type.Name);
                        typeNode.ImageKey = "ClassIcon";
                        typeNode.SelectedImageKey = "ClassIcon";

                        foreach (var method in type.Methods)
                        {
                            var methodNode = typeNode.Nodes.Add(method.FullName, method.Name);
                            methodNode.Tag = method;
                            methodNode.ImageKey = "MethodIcon";
                            methodNode.SelectedImageKey = "MethodIcon";
                        }
                    }
                }
            }

            treeLoadedAssemblies.EndUpdate();
        }

        private void LoadAssembly(FileInfo fileName)
        {
            var assembly = AssemblyDefinition.ReadAssembly(fileName.FullName);

            this.assemblies.Add(assembly);

            UpdateTree();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            Close();
        }

        private void Disassemble(object obj)
        {
            textEditor.Text = "";
            gridMethodOpCodes.Rows.Clear();

            if (obj is MethodDefinition)
            {
                DisassembleMethod((MethodDefinition)obj);
            }
            else if (obj is ModuleDefinition)
            {
                DisassembleModule((ModuleDefinition)obj);
            }
        }

        private void DisassembleModule(ModuleDefinition moduleDefinition)
        {
            textEditor.Text = moduleDefinition.Architecture.ToString();

            //throw new NotImplementedException();
        }

        private void DisassembleMethod(MethodDefinition methodDefinition)
        {
            if (methodDefinition.HasBody)
            {
                int i = 1;

                foreach (var instruction in methodDefinition.Body.Instructions)
                {
                    gridMethodOpCodes.Rows.Add(i++, instruction.Offset, instruction.OpCode, instruction.Operand);
                }
            }
        }

        private void treeLoadedAssemblies_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var treeView = (TreeView)sender;

            switch ((e.Action))
            {
                case TreeViewAction.ByKeyboard:
                case TreeViewAction.ByMouse:
                    Disassemble(treeView.SelectedNode.Tag);
                    break;
            }
        }
    }
}
