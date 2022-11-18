namespace DocumentModel.Wordprocessing;

/// <summary>
/// Theme Font Languages.
/// </summary>
public interface IThemeFontLanguages // : DocumentFormat.OpenXml.Wordprocessing.LanguageType
{
  /// <summary>
  /// Latin Language
  /// </summary>
  public string? Val { get ; set; }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  public string? EastAsia { get ; set; }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  public string? Bidi { get ; set; }
  
}
