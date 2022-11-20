namespace DocumentModel.Wordprocessing;

/// <summary>
/// Associated Help Text.
/// </summary>
public class HelpText: IHelpText
{
  /// <summary>
  /// Help Text Type
  /// </summary>
  public InfoTextValues? Type
  {
    get;
    set;
  }
  
  /// <summary>
  /// Help Text Value
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
}
