namespace DocumentModel.Drawings;

/// <summary>
/// Number Literal.
/// </summary>
public class NumberLiteralImpl: DocumentModel.Drawings.NumberDataTypeImpl, NumberLiteral
{
  public new DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberLiteral?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override String? FormatCode
  {
    get;
    set;
  }
  
  public override UInt32? PointCount
  {
    get;
    set;
  }
  
  public Collection<NumericPoint>? NumericPoints
  {
    get;
    set;
  }
  
  public ExtensionList4? ExtensionList
  {
    get;
    set;
  }
  
}
