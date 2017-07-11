using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SerializerAssignment.Models
{
    [Serializable()]
    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNum { get; set; }
        public DateTime RecordingDate { get; set; }
        public int SerialNumber
        {
            get { return _serialNumber; }
            set { _serialNumber = value; } 
        }

        [NonSerialized()]
        private int _serialNumber;
        [NonSerialized()]
        private static int _currentSerialNum;

        public Person()
        {
            RecordingDate = DateTime.Now;
            SerialNumber = GetHighestSerialNum() + 1;
        }

        public Person(string name, string address, string phoneNum)
        {
            Name = name;
            Address = address;
            PhoneNum = phoneNum;
            RecordingDate = DateTime.Now;
            SerialNumber = GetHighestSerialNum() + 1;
        }

        public void Serialize()
        {
            string serialNum = SerialNumStringFormatter(SerialNumber);
            string filePath = "person" + serialNum + ".dat";
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, this);
            stream.Close();
        }

        public static Person Deserialize(int serialNum)
        {
            string serialNumString = SerialNumStringFormatter(serialNum);
            string input = "person" + serialNumString + ".dat";
            Person person = new Person();
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(input, FileMode.Open, FileAccess.Read, FileShare.Read);
            person = (Person)formatter.Deserialize(stream);
            person.SerialNumber = serialNum;
            stream.Close();
            return person;
        }

        public static Person ShowFirst()
        {
            if (GetHighestSerialNum() != 0)
            {
                _currentSerialNum = 1;
                return Deserialize(1);
            }
            throw new FileNotFoundException();
        }

        public static Person ShowLast()
        {
            int highestNum = GetHighestSerialNum();
            if (highestNum != 0)
            {
                _currentSerialNum = highestNum;
                return Deserialize(highestNum);
            }
            throw new FileNotFoundException();
        }

        public static Person ShowNext()
        {
            _currentSerialNum++;
            int highest = GetHighestSerialNum();
            if (_currentSerialNum > highest)
            {
                _currentSerialNum = highest;
            }
            return Deserialize(_currentSerialNum);
        }

        public static Person ShowPrev()
        {
            _currentSerialNum--;
            if (_currentSerialNum == 0)
            {
                _currentSerialNum = 1;
            }
            return Deserialize(_currentSerialNum);
        }

        private static int GetHighestSerialNum()
        {
            int num = 0;
            string path = GetCurrentPath();
            string regex = "person[0-9]{2}.dat";
            string[] files = Directory.GetFiles(path);

            foreach (string filePath in files)
            {
                Match m = Regex.Match(filePath, regex);
                if (m.Value != "")
                {
                    string currentSerialNumString = Regex.Match(m.Value, "[0-9]{2}").Value;
                    int currentSerialNum;

                    if (currentSerialNumString[0] == '0')
                    {
                        currentSerialNum = Int32.Parse(currentSerialNumString[1].ToString());
                    }
                    else
                    {
                        currentSerialNum = Int32.Parse(Regex.Match(m.Value, "[0-9]{2}").Value);
                    }

                    if (currentSerialNum >= num) num = currentSerialNum;
                }
            }
            if (num == 100) throw new Exception("Not possible to make new Persons.");
            return num;
        }

        private static string GetCurrentPath()
        {
            string result = Assembly.GetExecutingAssembly().Location;
            int index = result.LastIndexOf(@"\");
            if (index >= 0)
            {
                result = result.Substring(0, index);
            }
            return result;
        }

        private static string SerialNumStringFormatter(int num)
        {
            string serialNum;
            if (num < 10)
            {
                serialNum = "0" + num;
            }
            else
            {
                serialNum = num.ToString();
            }
            return serialNum;
        }
    }
}
