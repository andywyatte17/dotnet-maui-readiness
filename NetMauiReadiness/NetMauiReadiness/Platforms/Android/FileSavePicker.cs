
namespace NetMauiReadiness.Services
{
    public class FileSavePicker : IFileSavePicker
    {
        public Task<string> ShowDialogAndGetFile()
        {
            return Task.FromResult<string>(null);
        }
    }
}