namespace DocumentModel.Drawings;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public class XValuesImpl: DocumentModel.Drawings.AxisDataSourceType1Impl, XValues
{
  public new DocumentFormat.OpenXml.Drawing.Charts.XValues? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.XValues?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override MultiLevelStringReference? MultiLevelStringReference
  {
    get;
    set;
  }
  
  public override NumberReference? NumberReference
  {
    get;
    set;
  }
  
  public override NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
  public override StringReference? StringReference
  {
    get;
    set;
  }
  
  public override StringLiteral? StringLiteral
  {
    get;
    set;
  }
  
}
