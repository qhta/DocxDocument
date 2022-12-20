namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public partial interface StringCache
{
  public UInt32? PointCount { get; set; }
  
  public Collection<DocumentModel.Drawings.Charts.StringPoint>? StringPoints { get; set; }
  
  public DocumentModel.Drawings.Charts.StrDataExtensionList? StrDataExtensionList { get; set; }
  
}
