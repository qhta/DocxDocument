namespace DocumentModel.Drawings;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public interface CatAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public NumberingFormat2? NumberingFormat { get ; set; }
  
}
