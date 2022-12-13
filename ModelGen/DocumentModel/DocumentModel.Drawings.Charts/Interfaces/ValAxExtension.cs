namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ValAxExtension Class.
/// </summary>
public interface ValAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get ; set; }
  
  public DocumentModel.Drawings13.Charts.NumberingFormat? NumberingFormat { get ; set; }
  
}
