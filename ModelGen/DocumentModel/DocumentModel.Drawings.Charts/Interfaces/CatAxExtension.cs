namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the CatAxExtension Class.
/// </summary>
public interface CatAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings.Charts.NumberingFormat3? NumberingFormat { get ; set; }
  
}
