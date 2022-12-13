namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Minus.
/// </summary>
public class MinusImpl: DocumentModel.Drawings.Charts.NumberDataSourceTypeImpl, Minus
{
  public new DocumentFormat.OpenXml.Drawing.Charts.Minus? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Minus?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public MinusImpl(): base() {}
  
  public MinusImpl(DocumentFormat.OpenXml.Drawing.Charts.Minus openXmlElement): base(openXmlElement)
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
