namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public interface DataLabelsRangeChache // : DocumentModel.Drawings.StringDataType
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<StringPoint>? StringPoints { get ; set; }
  
  public StrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
