namespace DocumentModel.Drawing;

/// <summary>
/// String Literal.
/// </summary>
public interface IStringLiteral // : DocumentModel.Drawing.IStringDataType
{
  public System.UInt32? PointCount { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IStringPoint>? StringPoints { get ; set; }
  
  public DocumentModel.Drawing.IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
