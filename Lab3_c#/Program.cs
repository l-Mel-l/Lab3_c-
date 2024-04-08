public struct Student{
    public string Name;
    public string GroupNumber;
    public int[] Grades;

    public Student(string name, string groupnumber, int[] grades){}

    // Метод для расчета среднего балла
    public double GetAverageGrade(){
        double sum = 0;
        foreach (int grade in Grades){
            sum += grade;
        }
        return sum / Grades.Length;
    }
}
public class Program{
    public static void Main(){
        Student[] students = new Student[]{
            new Student("Збанацкий Д.Е.", "20ИТ15", new int[] { 4, 5, 5, 3, 4 }),
            new Student("Петров П.П.", "20ИТ15", new int[] { 3, 4, 4, 5, 3 }),
            new Student("Бушманова Е.И.", "21ИТ17", new int[] { 4, 3, 3, 3, 2 }),
            new Student("Табаргин А.В.", "21ит17", new int[] { 3, 4, 4, 4, 3 }),
            new Student("Иванов И.И.", "23ИТ25", new int[] { 4, 5, 5, 5, 5 }),
            new Student("Букаткин А.П.", "21ИТ17", new int[] { 3, 4, 4, 3, 3 }),
            new Student("Казаков И.Д.", "21ИТ17", new int[] { 2, 2, 2, 3, 3 })
        };

        var sorteredStudents = students.OrderBy(s => s.GetAverageGrade());

        foreach (var student in sorteredStudents){
            Console.WriteLine($"Студент {student.Name} из группы ({student.GroupNumber}) - Средний балл: {student.GetAverageGrade()}");
        }
    }
}