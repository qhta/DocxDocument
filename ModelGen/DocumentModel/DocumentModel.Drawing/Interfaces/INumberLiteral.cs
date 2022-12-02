namespace DocumentModel.Drawing;

/// <summary>
/// Number Literal.
/// </summary>
public interface INumberLiteral // : DocumentModel.Drawing.INumberDataType
{
  public String? FormatCode { get ; set; }
  
  public UInt32? PointCount { get ; set; }
  
  public Collection<INumericPoint>? NumericPoints { get ; set; }
  
  public IExtensionList? ExtensionList { get ; set; }
  
}
