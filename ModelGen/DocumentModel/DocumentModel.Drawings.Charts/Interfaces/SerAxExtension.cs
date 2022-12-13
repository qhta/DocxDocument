namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public interface SerAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.NumberingFormat? NumberingFormat { get ; set; }
  
}
