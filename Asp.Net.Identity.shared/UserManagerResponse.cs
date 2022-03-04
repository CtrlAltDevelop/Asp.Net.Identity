namespace Asp.Net.Identity.shared;

public class UserManagerResponse
{
    public string Message { get; set; }
    
    public bool IsSuccess { get; set; }

    public IEnumerable<string> Error { get; set; }
}
