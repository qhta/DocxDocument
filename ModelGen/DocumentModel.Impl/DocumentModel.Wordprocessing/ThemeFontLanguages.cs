namespace DocumentModel.Wordprocessing;

/// <summary>
/// Theme Font Languages.
/// </summary>
public class ThemeFontLanguages: IThemeFontLanguages
{
  /// <summary>
  /// Latin Language
  /// </summary>
  public string? Val
  {
    get;
    set;
  }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  public string? EastAsia
  {
    get;
    set;
  }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  public string? Bidi
  {
    get;
    set;
  }
  
}
