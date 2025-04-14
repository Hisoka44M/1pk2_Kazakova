namespace Task_23_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowDrivesInfo();
            ShowUsersDirectoryContent();
            WorkWithDirectories();
        }

        static void ShowDrivesInfo()
        {
            Console.WriteLine("=== 1. Диски в системе ===");

            foreach (DriveInfo drive in DriveInfo.GetDrives())
            {
                Console.WriteLine($"Диск: {drive.Name}");

                if (drive.IsReady)
                {
                    Console.WriteLine($"  Тип: {drive.DriveType}");
                    Console.WriteLine($"  Метка: {drive.VolumeLabel}");
                    Console.WriteLine($"  Размер: {drive.TotalSize / 1024 / 1024 / 1024} ГБ");
                    Console.WriteLine($"  Доступно: {drive.AvailableFreeSpace / 1024 / 1024 / 1024} ГБ");
                }

                Console.WriteLine();
            }
        }

        static void ShowUsersDirectoryContent()
        {
            Console.WriteLine("=== 2. Содержимое C:\\Users ===");
            string path = @"C:\Users";

            if (Directory.Exists(path))
            {
                string[] folders = Directory.GetDirectories(path);
                if (folders.Length > 0)
                {
                    foreach (string folder in folders)
                        Console.WriteLine("  " + Path.GetFileName(folder));
                }
                else
                {
                    Console.WriteLine("  Каталог пуст.");
                }
            }
            else
            {
                Console.WriteLine("  Каталога не существует.");
            }

            Console.WriteLine();
        }

        static void WorkWithDirectories()
        {
            Console.WriteLine("=== 3. Работа с каталогами на диске D ===");

            string basePath = @"D:\work";
            string tempFolder = Path.Combine(basePath, "temp");
            string newTempFolder = Path.Combine(basePath, "newTemp");

            if (!Directory.Exists(basePath))
            {
                Directory.CreateDirectory(basePath);
                Console.WriteLine("Создана папка work.");
            }
            else
            {
                Console.WriteLine("Папка work уже существует.");
            }

            if (!Directory.Exists(tempFolder))
            {
                Directory.CreateDirectory(tempFolder);
                Console.WriteLine("Создан вложенный каталог temp.");
            }
            else
            {
                Console.WriteLine("Каталог temp уже существует.");
            }

            DirectoryInfo workDir = new DirectoryInfo(basePath);
            DirectoryInfo tempDir = new DirectoryInfo(tempFolder);

            Console.WriteLine("\nИнформация о каталоге work:");
            PrintDirInfo(workDir);

            Console.WriteLine("\nИнформация о вложенном каталоге temp:");
            PrintDirInfo(tempDir);

            Console.WriteLine("\n=== 4. Перемещение каталога temp в newTemp ===");
            try
            {
                if (Directory.Exists(tempFolder))
                {
                    Directory.Move(tempFolder, newTempFolder);
                    Console.WriteLine("Каталог успешно перемещён в newTemp.");
                }
                else
                {
                    Console.WriteLine("Каталог temp не найден для перемещения.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при перемещении: " + ex.Message);
            }

            Console.WriteLine("\n=== 5. Удаление каталога temp ===");
            try
            {
                if (Directory.Exists(tempFolder))
                {
                    Directory.Delete(tempFolder, true);
                    Console.WriteLine("Каталог temp успешно удалён.");
                }
                else
                {
                    Console.WriteLine("Каталог temp не найден (возможно, уже перемещён).");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при удалении: " + ex.Message);
            }
        }

        static void PrintDirInfo(DirectoryInfo dir)
        {
            Console.WriteLine($"  Имя: {dir.Name}");
            Console.WriteLine($"  Полный путь: {dir.FullName}");
            Console.WriteLine($"  Родитель: {dir.Parent}");
            Console.WriteLine($"  Создан: {dir.CreationTime}");
            Console.WriteLine($"  Последний доступ: {dir.LastAccessTime}");
            Console.WriteLine($"  Последнее изменение: {dir.LastWriteTime}");
        }
    }
}
