namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LanguageType Class.
/// </summary>
public interface LanguageType
{
  /// <summary>
  /// Latin Language
  /// </summary>
  public String? Val { get ; set; }
  
  /// <summary>
  /// East Asian Language
  /// </summary>
  public String? EastAsia { get ; set; }
  
  /// <summary>
  /// Complex Script Language
  /// </summary>
  public String? Bidi { get ; set; }
  
}
