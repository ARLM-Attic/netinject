using System;
using Mono.Cecil;
using Mono.Cecil.Cil;
using Mono.Collections.Generic;
using System.Windows.Forms;

namespace NetInject.App
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
            
            // string fileName = @"C:\Program Files (x86)\Dominion\Dominion_Data\Managed\Tmp\Assembly-CSharp.dll";
            //string fileName = @"C:\Users\Tom\Desktop\InjectionTest\InjectedDll\bin\Debug\InjectedDll.exe";

            //  string output = @"C:\Program Files (x86)\Dominion\Dominion_Data\Managed\Assembly-CSharp.dll";
            //string output = "InjectedDll-patched.exe";

            //    var p = new Program();
            //  p.Test(fileName, output);

            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
        }



        //private MethodReference ConsoleInjector(AssemblyDefinition assembly)
        //{
        //    MethodReference allocConsoleReference = GenerateAllocConsole(assembly);
        //    MethodReference attachConsole = AttachConsole(assembly);

        //    FieldReference hasConsoleStartedDefinitionReference = GenerateHasConsoleStartedField(assembly);
        //    MethodReference injectConsoleReference = GenerateInjectConsole(assembly, allocConsoleReference, attachConsole, hasConsoleStartedDefinitionReference);


        //    //// Define
        //    //var methodAttributes = MethodAttributes.Public | MethodAttributes.HideBySig | MethodAttributes.SpecialName | MethodAttributes.RTSpecialName | MethodAttributes.Static;
        //    //var method = new MethodDefinition(".ctor", methodAttributes, assembly.MainModule.TypeSystem.Void);

        //    //// Instruct
        //    ////method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldarg_0));
        //    //method.Body.Instructions.Add(Instruction.Create(OpCodes.Ldc_I4_0));
        //    //method.Body.Instructions.Add(Instruction.Create(OpCodes.Stsfld, hasConsoleStartedDefinitionReference));

        //    //method.Body.Instructions.Add(Instruction.Create(OpCodes.Ret));

        //    // Inject
        //    //    assembly.MainModule.Types[0].Methods.Add(method);


        //    return injectConsoleReference;
        //}

        //private static MethodReference GenerateInjectConsole(AssemblyDefinition assembly, MethodReference allocConsoleReference, MethodReference attachConsole, FieldReference hasConsoleStartedDefinitionReference)
        //{
        //    // Definition
        //    var injectConsoleDefinition = new MethodDefinition("InjectConsole", MethodAttributes.Public | MethodAttributes.Static, assembly.MainModule.TypeSystem.Void);

        //    // OpCodes
        //    var codes = injectConsoleDefinition.Body.Instructions;

        //    codes.Add(Instruction.Create(OpCodes.Ldsfld, hasConsoleStartedDefinitionReference));
        //    codes.Add(Instruction.Create(OpCodes.Ldc_I4_0));
        //    codes.Add(Instruction.Create(OpCodes.Ceq));

        //    var nop = Instruction.Create(OpCodes.Nop);

        //    codes.Add(Instruction.Create(OpCodes.Brfalse_S, nop));

        //    codes.Add(Instruction.Create(OpCodes.Nop));


        //    codes.Add(Instruction.Create(OpCodes.Ldc_I4_M1));
        //    codes.Add(Instruction.Create(OpCodes.Call, attachConsole));
        //    codes.Add(Instruction.Create(OpCodes.Ldc_I4_0));
        //    codes.Add(Instruction.Create(OpCodes.Ceq));

        //    //  var nop2 = Instruction.Create(OpCodes.Nop);

        //    codes.Add(Instruction.Create(OpCodes.Brfalse_S, nop));

        //    // codes.Add(Instruction.Create(OpCodes.Nop, nop2));

        //    codes.Add(Instruction.Create(OpCodes.Call, allocConsoleReference));
        //    codes.Add(Instruction.Create(OpCodes.Pop));
        //    codes.Add(Instruction.Create(OpCodes.Ldc_I4_1));
        //    codes.Add(Instruction.Create(OpCodes.Stsfld, hasConsoleStartedDefinitionReference));


        //    codes.Add(nop);

        //    codes.Add(Instruction.Create(OpCodes.Ret));


        //    // Inject
        //    assembly.MainModule.Types[0].Methods.Add(injectConsoleDefinition);
        //    var injectConsoleReference = assembly.MainModule.Import(injectConsoleDefinition);
        //    return injectConsoleReference;
        //}

        //private static FieldReference GenerateHasConsoleStartedField(AssemblyDefinition assembly)
        //{
        //    // Definition
        //    var hasConsoleStartedDefinition = new FieldDefinition("hasConsoleStarted", FieldAttributes.Private | FieldAttributes.Static, assembly.MainModule.TypeSystem.Boolean);

        //    // Inject
        //    assembly.MainModule.Types[0].Fields.Add(hasConsoleStartedDefinition);
        //    var hasConsoleStartedDefinitionReference = assembly.MainModule.Import(hasConsoleStartedDefinition);
        //    return hasConsoleStartedDefinitionReference;
        //}

        //private static MethodReference GenerateAllocConsole(AssemblyDefinition assembly)
        //{
        //    // Add References
        //    var kernel32Reference = new ModuleReference("kernel32.dll");
        //    assembly.MainModule.ModuleReferences.Add(kernel32Reference);

        //    // Definition
        //    var allocConsoleDefinition = new MethodDefinition("AllocConsole", MethodAttributes.Public | MethodAttributes.Static | MethodAttributes.PInvokeImpl, assembly.MainModule.TypeSystem.Boolean)
        //    {
        //        PInvokeInfo = new PInvokeInfo(PInvokeAttributes.SupportsLastError | PInvokeAttributes.CharSetNotSpec | PInvokeAttributes.CallConvWinapi, "AllocConsole", kernel32Reference)
        //    };

        //    // Inject
        //    assembly.MainModule.Types[0].Methods.Add(allocConsoleDefinition);
        //    var allocConsoleReference = assembly.MainModule.Import(allocConsoleDefinition);
        //    return allocConsoleReference;
        //}



        //private void Test(string pathBin, string output)
        //{
        //    AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(pathBin);

        //    // var consoleReference = ConsoleInjector(assembly);
        //    var consoleHelperReference = assembly.MainModule.Import(typeof(ConsoleHelper));

        //    var createConsoleType = typeof(ConsoleHelper).GetMethod("CreateConsole", new Type[] { });
        //    var createConsoleRef = assembly.MainModule.Import(createConsoleType);

        //    foreach (var typeDef in assembly.MainModule.Types)
        //    {
        //        if (typeDef.Name == "<Module>" || typeDef.Name == "ConsoleHelper" || typeDef.Name != "NodeConnector")
        //        {
        //            continue;
        //        }

        //        foreach (var method in typeDef.Methods)
        //        {
        //            if (method.Name == "sendController")
        //            {
        //                int i = 0;

        //                method.Body.Instructions.Insert(i++, Instruction.Create(OpCodes.Call, createConsoleRef));
        //                method.Body.Instructions.InsertRange(ref i, WriteLine(assembly, method.Name));

        //                var writeLineMethod = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) });
        //                var writeLineRef = assembly.MainModule.Import(writeLineMethod);

              
        //                method.Body.Instructions.Insert(i++, Instruction.Create(OpCodes.Ldarg_1));
        //                method.Body.Instructions.Insert(i++, Instruction.Create(OpCodes.Call, writeLineRef));
        //            }

        //            else
        //            {
        //                if (method.HasBody)
        //                {
        //                    int i = 0;

        //                    method.Body.Instructions.Insert(i++, Instruction.Create(OpCodes.Call, createConsoleRef));
        //                    method.Body.Instructions.InsertRange(ref i, WriteLine(assembly, method.Name));
        //                }
        //            }
        //        }
        //    }

        //    assembly.Write(output);
        //}

        //private static Collection<Instruction> WriteLine(AssemblyDefinition assembly, string value)
        //{
        //    var instructions = new Collection<Instruction>();

        //    var writeLineMethod = typeof(Console).GetMethod("WriteLine", new Type[] { typeof(string) });
        //    var writeLineRef = assembly.MainModule.Import(writeLineMethod);

        //    instructions.Add(Instruction.Create(OpCodes.Ldstr, value));
        //    instructions.Add(Instruction.Create(OpCodes.Call, writeLineRef));

        //    return instructions;
        //}

        //private void PrintReferences(string fileName)
        //{
        //    AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(fileName);

        //    foreach (var reference in assembly.MainModule.AssemblyReferences)
        //    {
        //        Console.WriteLine(reference);
        //    }
        //}

        //public void Write(string fileName)
        //{
        //    //    ModuleDefinition module = ModuleDefinition.ReadModule(fileName);

        //    AssemblyDefinition assembly = AssemblyDefinition.ReadAssembly(fileName);

        //    //AssemblyNameReference reference = new AssemblyNameReference(@"C:\Users\Tom\Desktop\InjectionTest\InjectedDll\bin\Debug\InjectedDll.dll", new VersionParse("1.0.0.0"));
        //    assembly.MainModule.AssemblyReferences.Add(reference);


        //    assembly.Write("Assembly-CSharp.dll");
        //}

        //public void PrintTypes(string fileName)
        //{
        //    ModuleDefinition module = ModuleDefinition.ReadModule(fileName);
        //    foreach (TypeDefinition type in module.Types)
        //    {
        //        Console.WriteLine(type.FullName);
        //    }
        //}
    }
}
