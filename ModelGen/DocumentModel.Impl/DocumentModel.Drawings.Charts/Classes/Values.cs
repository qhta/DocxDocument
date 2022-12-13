namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the Values Class.
/// </summary>
public class ValuesImpl: DocumentModel.Drawings.Charts.NumberDataSourceTypeImpl, Values
{
  public new DocumentFormat.OpenXml.Drawing.Charts.Values? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Values?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ValuesImpl(): base() {}
  
  public ValuesImpl(DocumentFormat.OpenXml.Drawing.Charts.Values openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
  
}
