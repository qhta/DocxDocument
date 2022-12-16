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
  
  public DocumentModel.Drawings.Charts.NumberingFormat3? NumberingFormat { get ; set; }
  
}
