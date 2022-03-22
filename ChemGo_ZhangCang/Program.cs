using ChemGo_ZhangCang.CommandLine;


namespace ChemGo_ZhangCang
{
    class Program
    {
        /// <summary>
        /// 程序入口
        /// </summary>
        /// <param name="args">命令行参数</param>
        static void Main(string[] args)
        {
            CommandLineInformation commandLineInformation;
            try
            {
                CommandLine_App app = new CommandLine_App(args);
                app.Run();
                commandLineInformation = app.CommandLineInformation;
            }
            catch (CommandLine_Exception e)
            {
                Console.Write(e.Message);
                return;
            }
        }
    }
}

