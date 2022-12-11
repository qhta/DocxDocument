namespace DocumentModel.Drawings;

/// <summary>
/// Number Literal.
/// </summary>
public interface NumberLiteral
{
  public String? FormatCode { get ; set; }
  
  public UInt32? PointCount { get ; set; }
  
  public Collection<NumericPoint>? NumericPoints { get ; set; }
  
  public ExtensionList? ExtensionList { get ; set; }
  
}
