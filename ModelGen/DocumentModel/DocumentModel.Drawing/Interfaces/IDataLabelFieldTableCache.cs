namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelFieldTableCache Class.
/// </summary>
public interface IDataLabelFieldTableCache // : DocumentModel.Drawing.IStringDataType
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<IStringPoint>? StringPoints { get ; set; }
  
  public IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
