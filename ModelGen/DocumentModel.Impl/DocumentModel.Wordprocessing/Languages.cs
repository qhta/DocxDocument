namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the Languages Class.
/// </summary>
public class Languages: ILanguages
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
