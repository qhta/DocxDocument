namespace DocumentModel.Drawings;

/// <summary>
/// Defines the XValues Class.
/// </summary>
public class XValuesImpl: DocumentModel.Drawings.AxisDataSourceTypeImpl, XValues
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
  
  public new MultiLevelStringReference? MultiLevelStringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new StringReference? StringReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public new StringLiteral? StringLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
