using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemGo_ZhangCang.CommandLine
{
    internal class ZeroArgsAnalyser
    {
        /// <summary>
        /// 命令行信息
        /// </summary>
        private CommandLineInformation commandLineInformation;
        /// <summary>
        /// 命令行信息
        /// </summary>
        public CommandLineInformation CommandLineInformation { get => commandLineInformation; set => commandLineInformation = value; }


        public ZeroArgsAnalyser()
        {

        }

        /// <summary>
        /// 运行零参数分析器。对于零个参数值，不做具体分析。
        /// </summary>
        public void Run()
        {
            commandLineInformation.Initialize();
            //给出帮助信息
            Console.WriteLine("");
        }
    }
}
