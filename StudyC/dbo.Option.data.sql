SET IDENTITY_INSERT [dbo].[Option] ON
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (1, N'"Hello World!"', 1, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (2, N'console.WriteLine("Hello, World!");', 1, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (3, N'printf("Hello, World!");', 1, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (4, N'cout<<"Hello World!";', 1, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (5, N'cout<<"I am learning C";', 2, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (6, N'printf("I am learning C");', 2, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (7, N'I am learning C!', 2, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (8, N'console.WriteLine("I am learning C");', 2, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (9, N'num num=50;', 3, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (10, N'int num=50;', 3, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (11, N'char num=50;', 3, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (12, N'int 50=num;', 3, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (13, N'כל סוגי המשתנים תופסים אותו מקום בזיכרון.
', 4, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (14, N'המקום בזיכרון תלוי אך ורק בערך המשתנה.
', 4, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (15, N'int=4byte , floota=double=8byte , char=1byte.
', 4, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (16, N'אף תשובה אינה נכונה.
', 4, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (17, N'printf();
', 5, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (18, N'cout<<;', 5, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (19, N'console.WriteLine();
', 5, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (20, N'scanf();
', 5, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (21, N'cin>>;
', 6, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (22, N'scanner.next();
', 6, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (23, N'scanf();
', 6, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (24, N'printf();
', 6, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (25, N'אופרטורים משמשים לביצוע פעולות על משתנים וערכים.', 7, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (26, N'אופרטור + משמש לחלק שני משתנים.
', 7, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (27, N'אופרטור - משמש להוספת שני משתנים.
', 7, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (28, N'אין תשובה נכונה.
', 7, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (29, N'“5+7”;
', 8, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (30, N'5-7;', 8, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (31, N'scanf(5+7);
', 8, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (32, N'printf(5+7);
', 8, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (33, N'בעזרת משפטי תנאי אשר ליצור פעולה חוזרת.
', 9, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (34, N'משפטי תנאי בודקים האם התוכנית עובדת או לא.
', 9, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (35, N'בעזרת משפטי תנאי אפשר לקבוע אמת/שקר.
', 9, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (36, N'אין תשובה נכונה.
', 9, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (37, N'will();', 10, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (38, N'if();
', 10, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (39, N'true();', 10, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (40, N'false();', 10, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (41, N'לולאות משמשות אותנו בקוד שחוזר על עצמו.
', 11, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (42, N'אין תנאי עצירה ללולאות.
', 11, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (43, N'בעזרת לולאות אפשר לקבוע אמת/שקר.
', 11, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (44, N'אין תשובה נכונה.
', 11, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (45, N'fordo();', 12, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (46, N'if();
', 12, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (47, N'for(); , while();', 12, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (48, N'אין לולאות בשפת C.
', 12, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (49, N'אין שימוש יעיל במצביעים.
', 13, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (50, N'מצביע הינו משתנה אשר מכיל כתובת של משתנים אחרים.
', 13, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (51, N'מצביע הינו משתנה אשר מדפיס כוכבית.
', 13, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (52, N'אין תשובה נכונה.
', 13, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (53, N'int num = pointer;
', 14, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (54, N'int * num;
', 14, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (55, N'*num*;
', 14, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (56, N'אין תשובה נכונה.
', 14, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (57, N'מערך מכיל משתנים מכל הסוגים.
', 15, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (58, N'מערך ומחרוזת זה אותו דבר.
', 15, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (59, N'מערך מכיל נתונים רבים מאותו סוג משתנה.
', 15, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (60, N'אין תשובה נכונה.
', 15, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (61, N'string ch;
', 16, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (62, N'string ch[];
', 16, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (63, N'char ch[];
', 16, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (64, N'int ch[];
', 16, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (65, N'פוקנציה מחלקת את הקוד לחלקים קטנים וקריאים יותר.
', 17, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (66, N'פונקציות יכולות לסבך לנו את הקוד.
', 17, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (67, N'פונקציות לא משפרות לנו את הקוד.
', 17, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (68, N'אין תשובה נכונה.
', 17, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (69, N'void func() {scanf(“good);}
', 18, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (70, N'func(printf(“good);)
', 18, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (71, N'פונקציות אינן מדפיסות
', 18, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (72, N'void func() {printf(“good);}
', 18, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (73, N'מבנה הוא בדיוק כמו מערך.
', 19, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (74, N'למבנה יש שדות,שהם איברים בעלי טיפוסים ושמות שאנחנו בוחרים.
', 19, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (75, N'למבנה יכול להיות בשדות איברים מאותו סוג משתנה .
', 19, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (76, N'אין תשובה נכונה.
', 19, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (77, N'סוג חיה,שם חיה,גיל.
', 20, 1)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (78, N'סוג בן אדם, האם יש לחיה משקפיים.
', 20, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (79, N'סוג חיה,שם חיה,גיל, איזה מקצוע החיה עובדת.
', 20, 0)
INSERT INTO [dbo].[Option] ([Id], [Text], [QuestionId], [IsCorrect]) VALUES (80, N'אין תשובה נכונה.
', 20, 0)
SET IDENTITY_INSERT [dbo].[Option] OFF
