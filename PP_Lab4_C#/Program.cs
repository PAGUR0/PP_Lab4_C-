﻿using colledge;

class Program
{
    static void Main()
    {
        Student[] students = [
            new Student("Антипов", "Антип", "Петрович", "21ИТ14", 20),
            new Student("Павлюк", "Анатолий", "Иванович", "23ИТ34", 17),
            new Student("Белесов", "Матвей", "Евгеньевич", "21ИТ17", 18)
            ];
        library.Reader[] readers = [
            new library.Reader("Антипов", "Антип", "Петрович", 1, "Сисадмин", "12.02.2004", "89323451784"),
            new library.Reader("Павлюк", "Анатолий", "Иванович", 2, "Сисадмин", "30.09.2006", "89243346748"),
            new library.Reader("Белесов", "Матвей", "Евгеньевич", 3, "Программист", "05.12.2005", "83244239847")
            ];
    }
}

