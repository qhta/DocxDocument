namespace DocumentModel.Drawings;

/// <summary>
/// Line Default.
/// </summary>
public class LineDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, LineDefault
{
  public new DocumentFormat.OpenXml.Drawing.LineDefault? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.LineDefault?)_OpenXmlElement;
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
