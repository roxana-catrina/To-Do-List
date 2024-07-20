using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Task
    {
        private string numeTask;
        private DateTime dataTask;
        private string comentariiTask;

        public Task(string numeTask,DateTime dataTask,string comentariiTask) {
            this.numeTask = numeTask;
            this.dataTask = dataTask;
            this.comentariiTask= comentariiTask;
        }
        public string NumeTask { get {  return numeTask; } }
        public DateTime DataTask { get { return dataTask; } }
        public string ComentariiTask { get { return comentariiTask; } }
        public override string ToString()
        {
            return numeTask + " " + dataTask.ToString()+" " + comentariiTask;
        }
    }
}
