using Mono.Cecil.Cil;
using Mono.Collections.Generic;

namespace NetInject.App.Extensions
{
    public static class InstructionExtensions
    {
        public static void AddRange(this Collection<Instruction> destination, Collection<Instruction> source)
        {
            foreach (var instruction in source)
            {
                destination.Add(instruction);
            }
        }

        public static void InsertRange(this Collection<Instruction> destination, ref int index, Collection<Instruction> source)
        {
            foreach (var instruction in source)
            {
                destination.Insert(index++, instruction);
            }
        }
    }
}
