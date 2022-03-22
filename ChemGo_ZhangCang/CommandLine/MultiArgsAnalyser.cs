using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemGo_ZhangCang.CommandLine
{
    internal class MultiArgsAnalyser
    {
        /// <summary>
        /// 命令行参数
        /// </summary>
        private string[] args;

        /// <summary>
        /// 命令行信息
        /// </summary>
        private CommandLineInformation commandLineInformation;
        /// <summary>
        /// 命令行信息
        /// </summary>
        public CommandLineInformation CommandLineInformation { get => commandLineInformation; set => commandLineInformation = value; }

        public MultiArgsAnalyser(string[] args)
        {
            this.args = (string[])args.Clone();
        }

        /// <summary>
        /// 运行多参数分析器
        /// </summary>
        public void Run()
        {
            commandLineInformation.Initialize();
            throw new CommandLine_Exception("ChemGo.CommandLine.ArgsAnalysis.MultiArgsAnalyser.Run() Error. Too many args.");
        }
    }
}
