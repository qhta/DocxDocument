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
