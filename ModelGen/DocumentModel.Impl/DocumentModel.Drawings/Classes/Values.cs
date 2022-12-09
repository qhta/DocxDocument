namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Values Class.
/// </summary>
public class ValuesImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, Values
{
  public new DocumentFormat.OpenXml.Drawing.Charts.Values? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Values?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override NumberReference? NumberReference
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  public override NumberLiteral? NumberLiteral
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
