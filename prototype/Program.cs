namespace prototype
{
    class Student
    {
        public int Id { get; set; }
        public string name { get; set; }
        public Student Clone()
        {
            return (Student)this.MemberwiseClone();
        }
    }
}