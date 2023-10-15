namespace HomeWork_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var grand_father = new AdultFamilyMember() { Mother = null, Name = "Bob", WifeName = "Hana", Sex = Gender.Male };
            var father = new AdultFamilyMember() { Father = grand_father, Name = "Папа",WifeName = "Мама", Sex = Gender.Male };
            var mother = new AdultFamilyMember() { Mother = null, Name = "Мама", Sex = Gender.Female };
            var son = new FamilyMember() { Father = father, Mother = mother, Name = "Сын", WifeName = "Не женат", Sex = Gender.Male };
            var son2 = new FamilyMember() { Father = father, Mother = mother, Name = "Сын", WifeName = "Не женат", Sex = Gender.Male };
            grand_father.Children = new FamilyMember[] { father };
            mother.Children = new FamilyMember[] { son,son2 };
            father.Children = new FamilyMember[] { son,son2 };
            grand_father.Print(1);
            Console.ReadKey();
        } 
    }
}