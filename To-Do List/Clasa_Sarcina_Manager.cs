using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List
{
    internal class Clasa_Sarcina_Manager
    {
        string cale_utilizator;
        List<Task> taskuri;

        public Clasa_Sarcina_Manager(string cale_utilizator,List<Task> taskuri)
        {
            this.cale_utilizator = cale_utilizator;
            this.taskuri = taskuri;
        }
        public string GetCaleUtilizator() {  return cale_utilizator; }
        public List<Task> GetTaskuri() {  return taskuri; }
    }
}
