namespace DocumentModel.Drawings;

/// <summary>
/// String Literal.
/// </summary>
public class StringLiteralImpl: DocumentModel.Drawings.StringDataType1Impl, StringLiteral
{
  public new DocumentFormat.OpenXml.Drawing.Charts.StringLiteral? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringLiteral?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override UInt32? PointCount
  {
    get;
    set;
  }
  
  public Collection<StringPoint>? StringPoints
  {
    get;
    set;
  }
  
  public StrDataExtensionList? StrDataExtensionList
  {
    get;
    set;
  }
  
}
