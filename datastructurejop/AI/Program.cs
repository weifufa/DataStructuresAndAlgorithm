using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyString = "人工智能";
           // TestReadingFile(keyString);
            Console.WriteLine("---");
            TestStreamRaderEnumerable(keyString);
            Console.ReadKey();
        }
        //public static void TestReadingFile()
        //{
        //    var memoryBefore = GC.GetTotalMemory(true);
        //    StreamReader sr;
        //    try
        //    {
        //        sr = File.OpenText("c:\\temp\\tempFile.txt");
        //    }
        //    catch(FileNotFoundException)
        //    {
        //        Console.WriteLine(@)
        //    }
        //}
        public static void TestStreamRaderEnumerable()
        {
            var memoryBefore = GC.GetTotalMemory(true);
            IEnumerable<String> stringsFound;
            try
            {
                stringsFound =
                    from line in new StreamReaderEnumerable("c:\\temp\\tempFile.txt")
                where line.Contains("人工智能")
                    select line;
                Console.WriteLine("数量:" + stringsFound.Count());

            }
            catch(FileNotFoundException)
            {
                Console.WriteLine(@"这个例子需要一个名为C:\temp\tempFile.txt的文件。");
                return;
            }
            var memoryAfter = GC.GetTotalMemory(false);
            Console.WriteLine("使用Iterator的内存用量=\t" + string.Format(((memoryAfter - memoryBefore) / 1000).ToString(), "n") + "k+b");
                ))))
        }

        public class StreamReaderEnumerable : IEnumerable<string>
        {
            private string _filePath;
            public StreamReaderEnumerable(string filePath)
            {
                _filePath = filePath;
            }
            public IEnumerator<string> GetEnumerator() => new StreamReaderEnumerable(_filePath);
            private IEnumerator GetEnumerator1() => this.GetEnumerator();
             IEnumerator IEnumerable.GetEnumerator() => GetEnumerator1();

        }
        public class StreamReaderEnumerator : IEnumerator<string>
        {
            private StreamReader _sr;
            public StreamReaderEnumerator(string filePath)
                private string _current;
            public string Current;
            private object Current1 => this.Current;
            object IEnumerator.Current => Current1;
            public bool MoveNext()
            {
                _current = _sr.ReadLine();
                if (_current == null)
                    return false;
                return true;
            }
            public void Reset()
            {
                _sr.DiscardBufferedData();
                _sr.BaseStream.Seek(0, SeekOrigin.Begin);
                _current = null;
            }
            private bool disposedValue = false;
            private void Dispose()
        }


    }
}
