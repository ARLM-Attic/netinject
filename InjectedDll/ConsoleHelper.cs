using System;
using System.IO;
using System.Runtime.InteropServices;

namespace NetInject
{
    public static class ConsoleHelper
    {
        public static void CreateConsole()
        {
            if (!AttachConsole(ATTACH_PARENT_PROCESS))
            {
                if (Marshal.GetLastWin32Error() == ERROR_INVALID_HANDLE)
                {
                    if (!AllocConsole())
                    {
                        throw new Exception("Could not initialize console!");
                    }
                }
            }

            // stdOut
            var standardOutput = new StreamWriter(Console.OpenStandardOutput())
            {
                AutoFlush = true
            };
            Console.SetOut(standardOutput);

            // stdIn
            var standardInput = new StreamReader(Console.OpenStandardInput());
            Console.SetIn(standardInput);

            // stdErr
            var standardError = new StreamWriter(Console.OpenStandardError())
            {
                AutoFlush = true
            };
            Console.SetError(standardError);
        }

        [DllImport("kernel32", SetLastError = true)]
        static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        private static extern bool AttachConsole(int pid);

        const int ATTACH_PARENT_PROCESS = -1;

        /// <summary>
        /// Calling process is already attached to a console
        /// </summary>
        const int ERROR_ACCESS_DENIED = 5;

        /// <summary>
        /// The process doesn't have an existing console handle
        /// </summary>
        const int ERROR_INVALID_HANDLE = 6;
    }
}
