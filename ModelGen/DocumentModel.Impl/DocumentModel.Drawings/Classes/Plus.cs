namespace DocumentModel.Drawings;

/// <summary>
/// Plus.
/// </summary>
public class PlusImpl: DocumentModel.Drawings.NumberDataSourceTypeImpl, Plus
{
  public new DocumentFormat.OpenXml.Drawing.Charts.Plus? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.Plus?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PlusImpl(): base() {}
  
  public PlusImpl(DocumentFormat.OpenXml.Drawing.Charts.Plus openXmlElement): base(openXmlElement)
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
