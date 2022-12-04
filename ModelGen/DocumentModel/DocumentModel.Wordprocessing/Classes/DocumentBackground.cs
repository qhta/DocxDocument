namespace DocumentModel.Wordprocessing;

/// <summary>
/// Document Background.
/// </summary>
public class DocumentBackground
{
  /// <summary>
  /// themeColor
  /// </summary>
  public ThemeColorKind? ThemeColor
  {
    get;
    set;
  }
  
  /// <summary>
  /// Background.
  /// </summary>
  public DocumentModel.Vml.Background? Background
  {
    get;
    set;
  }
  
}
