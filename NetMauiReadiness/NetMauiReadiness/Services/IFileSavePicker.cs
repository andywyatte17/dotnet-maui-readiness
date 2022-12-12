
namespace NetMauiReadiness.Services
{
    public interface IFileSavePicker
    {
        Task<string> ShowDialogAndGetFile();
    }
}
