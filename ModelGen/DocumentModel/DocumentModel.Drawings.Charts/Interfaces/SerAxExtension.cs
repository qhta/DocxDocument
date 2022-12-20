namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the SerAxExtension Class.
/// </summary>
public partial interface SerAxExtension
{
  /// <summary>
  /// URI
  /// </summary>
  public String? Uri { get; set; }
  
  public DocumentModel.Drawings.Charts.NumberingFormat3? NumberingFormat { get; set; }
  
}
