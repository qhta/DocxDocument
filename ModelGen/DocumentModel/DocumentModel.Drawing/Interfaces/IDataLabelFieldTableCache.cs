namespace DocumentModel.Drawing;

/// <summary>
/// Defines the DataLabelFieldTableCache Class.
/// </summary>
public interface IDataLabelFieldTableCache // : DocumentModel.Drawing.IStringDataType
{
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStringPoint>? StringPoints { get ; set; }
  
  public DocumentModel.Drawing.IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
