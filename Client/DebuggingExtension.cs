using System.Text.Json;

namespace MyFirstBlazor.Client
{
    public static class DebuggingExtension
    {
        private static JsonSerializerOptions options = new JsonSerializerOptions{ WriteIndented = true };
        public static string ToJson(this object obj)
        => JsonSerializer.Serialize(obj, options);
    }
}

