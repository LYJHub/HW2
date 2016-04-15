using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    [TestFixture]
    public class test
    {
        [Test]
        public void fun1()
        {
            StringReader input = new StringReader("zhang	n12345	3年");
            StringReader input1 = new StringReader("${中文姓名}先生(身份证字号${身份证字号})为本校专任教师，聘期${年数}。");
            StringWriter output = new StringWriter();
            MergeDataAndDoc.Program.StringMethod(input, input1, output);
            Assert.That(output.ToString(), Is.EqualTo("zhang先生(身份证字号n12345)为本校专任教师，聘期3年。\r\n\r\n\r\n"));

        }
        [Test]
        public void fun2()
        {
            StringReader input = new StringReader("wang	  n12346  2年 ");
            StringReader input1 = new StringReader("${中文姓名}先生(身份证字号${身份证字号})为本校专任教师，聘期${年数}。");
            StringWriter output = new StringWriter();
            MergeDataAndDoc.Program.StringMethod(input, input1, output);
            Assert.That(output.ToString(), Is.EqualTo("wang先生(身份证字号n12346)为本校专任教师，聘期2年。\r\n\r\n\r\n"));

        }
    }
}