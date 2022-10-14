using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.Design;

namespace EmergencyQueue_Keeton
{

    class EmergencyRoom
    {

        private PriorityQueue<patients, int> queue;
        public int priority { get; set; }
        public EmergencyRoom()
        {
            queue = new PriorityQueue<patients, int>();
        }

        public void Enqueue(patients patientName, int Priority)
        {
            queue.Enqueue(patientName, Priority);
        }

        public void patientCount()
        {
            Console.WriteLine("\nThere are " + queue.Count + " in line.");
        }

        public patients Dequeue()
        {
            return queue.Dequeue();
        }

        public patients[] patientsNames()
        {


            patients[] name = new patients[queue.Count];
            for (int i = 0; i < name.Length; i++)
            {

                name[i] = queue.Dequeue();
            }

            foreach (patients patientNames in name)
            {
                queue.Enqueue(patientNames, priority);
            }

            foreach (patients patientNames in name)
            {
                Console.WriteLine(patientNames);
            }
            return name;

        }


        public patients[] removePatientName()
        {



            List<patients> pana = new List<patients>();

            patients[] newQueue = new patients[queue.Count];
            if (queue.Count == 0)
            {
                Console.WriteLine("\nQueue is clear. ");
                return newQueue;
            }

            string delete = queue.Dequeue().ToString();



            for (int i = 0; i < newQueue.Length; i++)
            {
                for (int j = 0; j < pana.Count; j++)
                {

                    newQueue[i] = queue.Dequeue();
                    if (delete != null)
                    {
                        newQueue[i].ToString().Equals(delete);
                        pana.RemoveAt(i);

                    }
                }
            }

            newQueue = pana.ToArray();
            foreach (patients pname in newQueue)
            {
                queue.Enqueue(pname, priority);

            }

            return newQueue;
        }
    }
}
