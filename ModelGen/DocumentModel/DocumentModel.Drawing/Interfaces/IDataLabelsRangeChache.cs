namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelsRangeChache Class.
/// </summary>
public interface IDataLabelsRangeChache // : DocumentModel.Drawing.IStringDataType
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<IStringPoint>? StringPoints { get ; set; }
  
  public IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
