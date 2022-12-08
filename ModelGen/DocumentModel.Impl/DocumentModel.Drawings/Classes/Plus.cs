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
    get;
    set;
  }
  
  public override NumberLiteral? NumberLiteral
  {
    get;
    set;
  }
  
}
