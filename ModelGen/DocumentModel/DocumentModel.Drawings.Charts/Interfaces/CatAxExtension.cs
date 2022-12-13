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
  
  public DocumentModel.Drawings13.Charts.NumberingFormat? NumberingFormat { get ; set; }
  
}
