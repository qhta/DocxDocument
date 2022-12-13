namespace DocumentModel.Drawings13.Charts;

/// <summary>
/// Defines the DataLabelFieldTableCache Class.
/// </summary>
public interface DataLabelFieldTableCache
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<DocumentModel.Drawings.Charts.StringPoint>? StringPoints { get ; set; }
  
  public DocumentModel.Drawings.Charts.StrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
