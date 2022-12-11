namespace DocumentModel.Drawings;

/// <summary>
/// Minus.
/// </summary>
public class MinusImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, Minus
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
  
}
