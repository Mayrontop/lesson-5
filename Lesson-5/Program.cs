namespace Lesson_5
{

    using System.ComponentModel;
    using System.Data.SqlTypes;
    using System.Runtime.CompilerServices;
    using System.Windows.Markup;


   
        public class Int
        {

            protected int _num;
            public int n { get { return this._num; } set { this._num = value; } }

            public Int(int num)
            {
                this._num = num;
            }
            public static Int operator +(Int i1, Int i2)
            {
                return new Int(i1.n + i2.n);
            }
            public override string ToString()
            {
                return _num.ToString();
            }
            public static Int operator *(Int i1, Int i2)
            {
                return new Int(i1.n * i2.n);
            }
            public override bool Equals(object a)
            {
                if (a == null) return false;
                return this.GetHashCode() == a.GetHashCode();
            }
            public override int GetHashCode()
            {
                return this.n.GetHashCode();
            }

            public static bool operator ==(Int a, Int b)
            {
                return a.n == b.n;
            }
            public static bool operator !=(Int a, Int b)
            {
                return a.n != b.n;
            }

            public static bool operator <(Int a, Int b)
            {
                return a.n < b.n;
            }

            public static bool operator >(Int a, Int b)
            {
                return a.n > b.n;
            }

            public static bool operator true(Int i)
            {
                return i.n != 0;
            }
            public static bool operator false(Int i)
            {
                return i.n == 0;
            }
            public static implicit operator int(Int i)
            {
                return i.n;
            }
        }


        class Student
        {
            public string? fn { get; set; }
            public string? ln { get; set; }

            public int? age { get; set; }

            public Student(string fn, string ln, int age)
            {
                this.fn = fn;
                this.ln = ln;
                this.age = age;
            }
            public override string ToString()
            {
                return $"{fn}, {ln}, {age} лет";
            }
        }

        class Groop
        {
            public string? name { get; set; }
            protected List<Student> st = new List<Student>();
            public Groop(string name, params Student[] st)
            {
                this.name = name;
                foreach (Student student in st)
                    this.st.Add(student);

            }
            public float AvgAge()
            {
                int sum = 0;
                foreach (Student student in this.st)
                    sum += student.age ?? 0;
                return (float)sum / this.st.Count;
            }
            public Student this[int index]
            {
                get
                {
                    return this.st[index];
                }
            }
            public List<Student> this[string ln]
            {
                get
                {
                    List<Student> students = new();
                    foreach (Student student in this.st)
                        st.Add(student);
                    return st;
                }
            }

        }

        internal class Program
        {
            static void Main(string[] args)
            {


                Groop g = new Groop("211",
                    new Student("Cata", "err", 15),
                      new Student("rataa", "Ret", 15)
                    );

            }
        }
    }

