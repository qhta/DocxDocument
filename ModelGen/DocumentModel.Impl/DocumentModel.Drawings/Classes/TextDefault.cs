namespace DocumentModel.Drawings;

/// <summary>
/// Text Default.
/// </summary>
public class TextDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, TextDefault
{
  public new DocumentFormat.OpenXml.Drawing.TextDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.TextDefault?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public override ShapeProperties8? ShapeProperties
  {
    get;
    set;
  }
  
  public override BodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  public override ListStyle? ListStyle
  {
    get;
    set;
  }
  
  public override ShapeStyle1? ShapeStyle
  {
    get;
    set;
  }
  
  public override ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
