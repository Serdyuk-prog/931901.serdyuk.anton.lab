using Microsoft.AspNetCore.StaticFiles;

namespace Lab6.Services
{
    public class MimeMappingService
    {
        public String GetContentType(String extension)
        {
            var provider = new FileExtensionContentTypeProvider();
            return provider.TryGetContentType($"file.{extension}", out var result) ? result : "application/unknown";
        }
    }
}
