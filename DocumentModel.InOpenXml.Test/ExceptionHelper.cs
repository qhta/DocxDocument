namespace DocumentModel.InOpenXml.Test;

public static class ExceptionHelper
{
  public static string GetInternalMessages(this Exception ex)
  {
    var internalException = ex.InnerException;
    var messages = new List<string>();
    while (internalException != null)
    {
      messages.Add($"   Inner Exception: {internalException.Message}");
      internalException = internalException.InnerException;
    }
    return messages.Count > 0 ? string.Join("\n", messages) : "No inner exceptions";
  }
}