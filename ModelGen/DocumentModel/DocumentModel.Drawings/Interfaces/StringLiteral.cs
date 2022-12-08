namespace DocumentModel.Drawings;

/// <summary>
/// String Literal.
/// </summary>
public interface StringLiteral
{
  public UInt32? PointCount { get ; set; }
  
  public Collection<StringPoint>? StringPoints { get ; set; }
  
  public StrDataExtensionList? StrDataExtensionList { get ; set; }
  
}
