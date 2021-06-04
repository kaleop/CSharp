using System;
using System.Diagnostics;

namespace Lesson_6_1
{
    class Exercise_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запущенные процессы:");
            Process[] allProcesses = Process.GetProcesses();
            ShowProcessList(allProcesses);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nВведите имя процесса или ID чтобы завершить его");
            Console.ResetColor();
            string processKill = Console.ReadLine();
            Process selectedProcess;
            int ID = 0;
            try
            {
                if (Int32.TryParse(processKill, out ID) == true)
                {
                    selectedProcess = GetProcess(ID, allProcesses);
                }
                else
                {
                    selectedProcess = GetProcess(processKill, allProcesses);
                }
                selectedProcess.Kill();
            }
            catch (ProcessNotFound ex) when (ex.Code == Teg.ID)
            {
                Console.WriteLine("\nПроцес с таким ID не найден");
            }
            catch (ProcessNotFound ex) when (ex.Code == Teg.Name)
            {
                Console.WriteLine("\nПроцесс с таким именем не найден");
            }


            Console.ReadKey();
        }

        static void ShowProcessList(Process[] allProcesses)
        {
            for (int i = 0; i < allProcesses.Length; i++)
            {
                Console.WriteLine($"{allProcesses[i].ProcessName} \t{allProcesses[i].Id}");
            }
        }

        static Process GetProcess (string name, Process[] proc)
        {
            foreach (Process p in proc )
            {
                if (p.ProcessName == name)
                {
                    return p;
                }
            }
            throw new ProcessNotFound(Teg.Name);
        }
        static Process GetProcess(int ID, Process[] proc)
        {
            foreach (Process p in proc)
            {
                if (p.Id == ID)
                {
                    return p;
                }
            }
            throw new ProcessNotFound(Teg.ID);
        }



    }
}
