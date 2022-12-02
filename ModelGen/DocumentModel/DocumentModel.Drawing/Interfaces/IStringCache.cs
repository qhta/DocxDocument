namespace DocumentModel.Drawing;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public interface IStringCache // : DocumentModel.Drawing.IStringDataType
{
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStringPoint>? StringPoints { get ; set; }
  
  public DocumentModel.Drawing.IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
