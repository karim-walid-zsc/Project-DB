// using StudentPortal.Models;
// using Microsoft.EntityFrameworkCore;

// namespace StudentPortal.Data;

// public static class SeedData
// {
//     public static void Initialize(ApplicationDbContext context)
//     {
//         // تأكد من أن قاعدة البيانات منشأة
//         context.Database.EnsureCreated();

//         // إضافة بيانات الدكاترة إذا كانت فارغة
//         if (!context.Professors.Any())
//         {
//             var professors = new[]
//             {
//                 new Professor { Name = "د. أحمد محمد", Department = "علوم الحاسب", Email = "ahmed@university.edu", Office = "مبنى أ - مكتب ٣٠١", Phone = "٠١٠٠٢٣٤٥٦٧٨", OfficeHours = "الإثنين والأربعاء - ١٠ صباحاً إلى ١٢ ظهراً" },
//                 new Professor { Name = "د. مريم عبدالله", Department = "هندسة البرمجيات", Email = "mariam@university.edu", Office = "مبنى ب - مكتب ٢٠٥", Phone = "٠١٠٩٨٧٦٥٤٣٢", OfficeHours = "الثلاثاء والخميس - ٩ صباحاً إلى ١١ صباحاً" }
//             };
//             context.Professors.AddRange(professors);
//             context.SaveChanges();
//         }

//         // إضافة مواد دراسية إذا كانت فارغة
//         if (!context.Courses.Any())
//         {
//             var courses = new[]
//             {
//                 new Course { Code = "CS101", Name = "برمجة التطبيقات", Description = "مقدمة في برمجة التطبيقات باستخدام C#", CreditHours = 3, ProfessorId = 1 },
//                 new Course { Code = "CS102", Name = "قواعد البيانات", Description = "تصميم وإدارة قواعد البيانات", CreditHours = 3, ProfessorId = 2 },
//                 new Course { Code = "CS201", Name = "هندسة البرمجيات", Description = "مبادئ هندسة البرمجيات وتطوير الأنظمة", CreditHours = 4, ProfessorId = 1 }
//             };
//             context.Courses.AddRange(courses);
//             context.SaveChanges();
//         }

//         // إضافة امتحانات إذا كانت فارغة
//         if (!context.Exams.Any())
//         {
//             var exams = new[]
//             {
//                 new Exam { CourseId = 1, ExamType = "منتصف الفصل", ExamDate = new DateTime(2024, 12, 15), Time = "10:00 AM", Location = "قاعة 101", Duration = 3 },
//                 new Exam { CourseId = 2, ExamType = "منتصف الفصل", ExamDate = new DateTime(2024, 12, 17), Time = "01:00 PM", Location = "قاعة 202", Duration = 2 },
//                 new Exam { CourseId = 1, ExamType = "نهائي", ExamDate = new DateTime(2025, 1, 10), Time = "09:00 AM", Location = "قاعة 305", Duration = 3 }
//             };
//             context.Exams.AddRange(exams);
//             context.SaveChanges();
//         }

//         // إضافة إعلانات إذا كانت فارغة
//         if (!context.Announcements.Any())
//         {
//             var announcements = new[]
//             {
//                 new Announcement { Title = "تغيير موعد محاضرة", Content = "تم تأجيل محاضرة قواعد بيانات إلى يوم الأربعاء الساعة 10 صباحاً", Date = new DateTime(2024, 1, 16), IsImportant = true, Category = "مهم" },
//                 new Announcement { Title = "نتائج الامتحانات", Content = "ظهرت نتائج امتحانات منتصف الفصل، يمكن الاطلاع عليها من خلال النظام", Date = new DateTime(2024, 1, 15), IsImportant = true, Category = "مهم" }
//             };
//             context.Announcements.AddRange(announcements);
//             context.SaveChanges();
//         }
//     }
// }

using StudentPortal.Models;
using Microsoft.EntityFrameworkCore;

namespace StudentPortal.Data;

public static class SeedData
{
    public static void Initialize(ApplicationDbContext context)
    {
        // تأكد من أن قاعدة البيانات منشأة
        context.Database.EnsureCreated();

        // ===============================
        // Professors
        // ===============================
        if (!context.Professors.Any())
        {
            var professors = new[]
            {
                new Professor { Name = "د. أحمد محمد", Department = "علوم الحاسب", Email = "ahmed@uni.edu", Office = "A-301", Phone = "0100000001", OfficeHours = "Sun-Tue 10-12" },
                new Professor { Name = "د. مريم عبدالله", Department = "هندسة برمجيات", Email = "mariam@uni.edu", Office = "B-205", Phone = "0100000002", OfficeHours = "Mon-Wed 9-11" },
                new Professor { Name = "د. علي حسن", Department = "علوم الحاسب", Email = "ali@uni.edu", Office = "A-302", Phone = "0100000003", OfficeHours = "Sun-Tue 12-2" },
                new Professor { Name = "د. سارة محمود", Department = "نظم معلومات", Email = "sara@uni.edu", Office = "C-101", Phone = "0100000004", OfficeHours = "Mon-Thu 10-12" },
                new Professor { Name = "د. كريم سامي", Department = "هندسة برمجيات", Email = "karim@uni.edu", Office = "B-210", Phone = "0100000005", OfficeHours = "Sun-Wed 11-1" },
                new Professor { Name = "د. نهى عادل", Department = "علوم الحاسب", Email = "noha@uni.edu", Office = "A-310", Phone = "0100000006", OfficeHours = "Tue-Thu 9-11" },
                new Professor { Name = "د. يوسف عاطف", Department = "نظم معلومات", Email = "youssef@uni.edu", Office = "C-110", Phone = "0100000007", OfficeHours = "Sun-Tue 10-12" },
                new Professor { Name = "د. منى فتحي", Department = "هندسة برمجيات", Email = "mona@uni.edu", Office = "B-215", Phone = "0100000008", OfficeHours = "Mon-Wed 1-3" },
                new Professor { Name = "د. هشام صبري", Department = "علوم الحاسب", Email = "hesham@uni.edu", Office = "A-320", Phone = "0100000009", OfficeHours = "Sun-Thu 9-11" },
                new Professor { Name = "د. رانيا فؤاد", Department = "نظم معلومات", Email = "rania@uni.edu", Office = "C-120", Phone = "0100000010", OfficeHours = "Mon-Thu 12-2" }
            };

            context.Professors.AddRange(professors);
            context.SaveChanges();
        }

        // ===============================
        // Courses
        // ===============================
        if (!context.Courses.Any())
        {
            var courses = new[]
            {
                new Course { Code = "CS101", Name = "برمجة 1", Description = "مقدمة في البرمجة", CreditHours = 3, ProfessorId = 1 },
                new Course { Code = "CS102", Name = "قواعد بيانات", Description = "مبادئ SQL", CreditHours = 3, ProfessorId = 2 },
                new Course { Code = "CS103", Name = "هياكل بيانات", Description = "Data Structures", CreditHours = 4, ProfessorId = 3 },
                new Course { Code = "CS104", Name = "OOP", Description = "Object Oriented Programming", CreditHours = 3, ProfessorId = 4 },
                new Course { Code = "CS105", Name = "Web Development", Description = "ASP.NET Basics", CreditHours = 3, ProfessorId = 5 },
                new Course { Code = "CS106", Name = "Algorithms", Description = "Algorithm Analysis", CreditHours = 4, ProfessorId = 6 },
                new Course { Code = "CS107", Name = "Operating Systems", Description = "OS Concepts", CreditHours = 4, ProfessorId = 7 },
                new Course { Code = "CS108", Name = "Networks", Description = "Computer Networks", CreditHours = 3, ProfessorId = 8 },
                new Course { Code = "CS109", Name = "Software Engineering", Description = "SE Principles", CreditHours = 3, ProfessorId = 9 },
                new Course { Code = "CS110", Name = "AI Basics", Description = "Intro to AI", CreditHours = 3, ProfessorId = 10 }
            };

            context.Courses.AddRange(courses);
            context.SaveChanges();
        }


// ===============================
        // Exams
        // ===============================
        if (!context.Exams.Any())
        {
            var exams = new[]
            {
                new Exam { CourseId = 1, ExamType = "منتصف الفصل", ExamDate = new DateTime(2024,12,10), Time = "10:00", Location = "101", Duration = 2 },
                new Exam { CourseId = 2, ExamType = "منتصف الفصل", ExamDate = new DateTime(2024,12,11), Time = "12:00", Location = "102", Duration = 2 },
                new Exam { CourseId = 3, ExamType = "منتصف الفصل", ExamDate = new DateTime(2024,12,12), Time = "10:00", Location = "103", Duration = 3 },
                new Exam { CourseId = 4, ExamType = "منتصف الفصل", ExamDate = new DateTime(2024,12,13), Time = "12:00", Location = "104", Duration = 2 },
                new Exam { CourseId = 5, ExamType = "نهائي", ExamDate = new DateTime(2025,1,10), Time = "09:00", Location = "201", Duration = 3 },
                new Exam { CourseId = 6, ExamType = "نهائي", ExamDate = new DateTime(2025,1,11), Time = "11:00", Location = "202", Duration = 3 },
                new Exam { CourseId = 7, ExamType = "نهائي", ExamDate = new DateTime(2025,1,12), Time = "09:00", Location = "203", Duration = 3 },
                new Exam { CourseId = 8, ExamType = "نهائي", ExamDate = new DateTime(2025,1,13), Time = "11:00", Location = "204", Duration = 2 }
            };

            context.Exams.AddRange(exams);
            context.SaveChanges();
        }

        // ===============================
        // Announcements
        // ===============================
        if (!context.Announcements.Any())
        {
            var announcements = new[]
            {
                new Announcement { Title = "بدء الدراسة", Content = "بدء الفصل الدراسي الجديد", Date = new DateTime(2024,9,20), IsImportant = true, Category = "مهم" },
                new Announcement { Title = "إجازة رسمية", Content = "يوم الخميس إجازة", Date = new DateTime(2024,10,5), IsImportant = false, Category = "عام" },
                new Announcement { Title = "تنبيه امتحانات", Content = "الرجاء الالتزام بالمواعيد", Date = new DateTime(2024,12,1), IsImportant = true, Category = "مهم" },
                new Announcement { Title = "نتائج منتصف الفصل", Content = "تم رفع النتائج", Date = new DateTime(2024,12,25), IsImportant = true, Category = "مهم" }
            };

            context.Announcements.AddRange(announcements);
            context.SaveChanges();
        }

        // ===============================
        // Students
        // ===============================
        if (!context.Students.Any())
        {
            var students = new[]
            {
                new Student { Name = "محمد علي", Email = "s1@student.edu", PasswordHash = "123456", Department = "علوم الحاسب", AcademicYear = "الأولى" },
                new Student { Name = "أحمد محمود", Email = "s2@student.edu", PasswordHash = "123456", Department = "علوم الحاسب", AcademicYear = "الثانية" },
                new Student { Name = "سارة حسن", Email = "s3@student.edu", PasswordHash = "123456", Department = "نظم معلومات", AcademicYear = "الثالثة" },
                new Student { Name = "منى سامي", Email = "s4@student.edu", PasswordHash = "123456", Department = "هندسة برمجيات", AcademicYear = "الرابعة" }
            };

            context.Students.AddRange(students);
            context.SaveChanges();
        }

        
    }
}