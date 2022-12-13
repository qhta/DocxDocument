namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public class XValuesImpl: DocumentModel.Drawings.Charts.AxisDataSourceTypeImpl, XValues
{
  public new DocumentFormat.OpenXml.Drawing.Charts.XValues? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.XValues?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public XValuesImpl(): base() {}
  
  public XValuesImpl(DocumentFormat.OpenXml.Drawing.Charts.XValues openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  public new DocumentModel.Drawings.Charts.MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new DocumentModel.Drawings.Charts.StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
