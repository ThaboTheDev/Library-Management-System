using System.Text.Json;

namespace LibraryManagementSystem.Lib.Services
{
    public class DataHandler
    {
        private static JsonSerializerOptions JsonSerializerOptions { get; } = new JsonSerializerOptions() {WriteIndented = true};

        public static async Task<T> FetchData<T>(string filepath)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException($"The file was not found {filepath}");
            }

            try
            {
                string jsonContent = await File.ReadAllTextAsync(filepath);
                T data = JsonSerializer.Deserialize<T>(jsonContent)!;
                return data;
            }
            catch (JsonException e)
            {
                throw new InvalidOperationException($"Error deserializing json data from file {filepath}: {e.Message}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"An unexpected error occured while processing the file : {e.Message}", e);
            }
        }

        public static async Task<T> SaveData<T>(string filepath, T data)
        {
            if (!File.Exists(filepath))
            {
                throw new FileNotFoundException($"The file was not found {filepath}");
            }

            try
            {
                var UpdatedJson = JsonSerializer.Serialize(data, JsonSerializerOptions);
                File.WriteAllText(filepath, UpdatedJson);
                return await FetchData<T>(filepath);
            }
            catch (JsonException e)
            {
                throw new InvalidOperationException($"Error serializing json data {filepath}: {e.Message}", e);
            }
            catch (Exception e)
            {
                throw new Exception($"An unexpected error occured while processing the file : {e.Message}", e);
            }

        }
    } 
}