namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the FontCharSet Class.
/// </summary>
public class FontCharSet: IFontCharSet
{
  /// <summary>
  /// val
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// characterSet
  /// </summary>
  public StrictCharacterSet? StrictCharacterSet
  {
    get;
    set;
  }
  
}
