namespace DocumentModel.Drawing;

/// <summary>
/// String Literal.
/// </summary>
public interface IStringLiteral // : DocumentModel.Drawing.IStringDataType
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<IStringPoint>? StringPoints { get ; set; }
  
  public IStrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
