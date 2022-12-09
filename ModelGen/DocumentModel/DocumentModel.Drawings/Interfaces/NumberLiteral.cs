namespace DocumentModel.Drawings;

/// <summary>
/// Number Literal.
/// </summary>
public interface NumberLiteral
{
  public String? FormatCode { get ; set; }
  
  public UInt32? PointCount { get ; set; }
  
  public Collection<NumericPoint>? NumericPoints { get ; set; }
  
  public ExtensionList3? ExtensionList { get ; set; }
  
}
