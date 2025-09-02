namespace Day12Lab
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            //emp1.insert(new Employee());
            ((IOperation<Employee>)emp1).Saving();

            IOperation<Employee> emp2 = new Employee();
            emp2.Saving();

            Test t1 = new Test();
        }
    }

    public class Employee : Human , IOperation<Employee> , IStreamFile<Employee>
    {
        public void delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> getAll()
        {
            throw new NotImplementedException();
        }

        public Employee getById(int id)
        {
            throw new NotImplementedException();
        }

        public override int getID()
        {
            throw new NotImplementedException();
        }

        public void insert(Employee obj)
        {
            throw new NotImplementedException();
        }

        public void update(Employee obj)
        {
            throw new NotImplementedException();
        }

        void IStreamFile<Employee>.insert(Employee obj)
        {
            throw new NotImplementedException();
        }

        byte[] IStreamFile<Employee>.readFile()
        {
            throw new NotImplementedException();
        }

        void IStreamFile<Employee>.writeFile(Employee file)
        {
            throw new NotImplementedException();
        }
    }

    public abstract class Human
    {
        public abstract int getID();
    } 
    public interface IOperation<T>
    {
        //int x;// Error: Interfaces cannot contain fields

        public T getById(int id);

        public IEnumerable<T> getAll();

        public void insert(T obj);

        public void update(T obj);

        public void delete(int id);

        public void Saving() 
        {
            Console.WriteLine("Saving data..."); 
        } // from C# 8.0 onwards, interfaces can have default implementations for methods
    }

    public interface IStreamFile<T>
    {
        public void insert(T obj);
        public byte[] readFile();
        public void writeFile(T file);
    }

    public class Test
    {
        public Test() : this("Default Constructor")
        {
            
        }

        public Test(string str)
        {
            Console.WriteLine(str);
        }
    }

    public class Test2 : Test
    {
        public Test2(string str) : base(str) // calling base class constructor from the parent constructor
        {
            
        }
    }
}