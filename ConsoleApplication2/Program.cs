using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication2.Models;
using ConsoleApplication2.BussinessLayer;

namespace ConsoleApplication2
{
   public class Program
    {
        static void Main(string[] args)
        {
                createClassName();                
                Console.WriteLine("按任意键退出");
                Console.ReadKey();
            }
            //增加--交互
            static void createClassName()
        {
                Console.WriteLine("请输入一个班级名称");
                string name = Console.ReadLine();
                ClassName CN = new ClassName();
                CN.Name = name;
            StuBussinessLayer bbl = new StuBussinessLayer();
                bbl.Add(CN);
            }
        }
    }

