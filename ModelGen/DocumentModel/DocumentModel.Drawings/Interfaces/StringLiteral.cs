namespace DocumentModel.Drawings;

/// <summary>
/// String Literal.
/// </summary>
public interface StringLiteral // : DocumentModel.Drawings.StringDataType
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<StringPoint>? StringPoints { get ; set; }
  
  public StrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
