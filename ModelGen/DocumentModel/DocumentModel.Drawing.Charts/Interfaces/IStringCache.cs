namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the StringCache Class.
/// </summary>
public interface IStringCache // : DocumentModel.Drawing.Charts.IStringDataType
{
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Charts.IStringPoint>? StringPoints { get ; set; }
  
  public DocumentModel.Drawing.Charts.IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
