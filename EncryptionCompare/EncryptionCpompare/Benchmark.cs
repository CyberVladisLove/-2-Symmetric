using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptionCompare
{
    class Benchmark
    {
        public static List<Row> AlgorithmsBenchmark(string content)
        {
            List<Algorithm> algs = InitAlgorithms();

            var rows = new List<Row>();

            for(int i = 0; i < algs.Count; i++)
            {
                var alg = algs[i];

                for (int j = 0; j < Algorithm.cypherModeCount; j++)
                {
                    try
                    {
                        var cm = Algorithm.GetCipherMode(j);
                        alg.SetCipherMode(cm);
                        var time = Timer(() => alg.Encryption_Decryption(content));
                        var row = new Row(alg.Name, cm.ToString(), time.ToString());
                        rows.Add(row);
                    }
                    catch(Exception ex)
                    {
                        continue;
                    }
                    
                }
            }
            return rows.OrderBy(x => x.Time).ToList();
        }

        public static List<Algorithm> InitAlgorithms()
        {
            var des = new Algorithm(DES.Create(), "DES");
            var tripleDes = new Algorithm(TripleDES.Create(), "3DES");
            var rijndael = new Algorithm(Rijndael.Create(), "Rijndael");     
            var rc2 = new Algorithm(RC2.Create(), "RC2");

            List<Algorithm> algs = new();
            algs.Add(rijndael);
            algs.Add(tripleDes);
            algs.Add(des);
            algs.Add(rc2);

            return algs;
        }


        public static TimeSpan Timer(Action action)
        {
            var timer = new System.Diagnostics.Stopwatch(); 
            timer.Start(); 
            action();
            timer.Stop(); 
            return timer.Elapsed; 
        }
    }
}
