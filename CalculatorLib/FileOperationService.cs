namespace CalculatorLib
{
    public class FileOperationService
    {
        public void SaveResult(string calculateResult)
        {
            var line = string.Empty;
            var fileName = string.Empty;

            line = $"{calculateResult}\n";
            fileName = "SavedResults.txt";

            try
            {
                File.AppendAllText(fileName, line);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Blad zapisu:{ex.Message}");
            }
        }
    }
}
