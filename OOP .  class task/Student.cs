
namespace OOP_.__class_task
{
    class Student
    {
        public string name;
        public string surname;
        public int age;
        public string address;
        public string phone="1234432112";

        //public  void ShowText(string text)
        //{
        //    Console.WriteLine(text);

        //}
        public string GetFullname()
        {
            return name+ "  " +surname;
        }

        public string GetFullDatas()
        {
            string fullData = $"Name: {name } , Surname:{surname}" + $"Age {age},Address:{address} , Phone: {phone}";


            return fullData;
        }

        public void ShowAll(Student[] datas)
        {
            foreach (var item in datas)
            {
                //Console.WriteLine(item.GetFullDatas());

            }
        }

    }
}
