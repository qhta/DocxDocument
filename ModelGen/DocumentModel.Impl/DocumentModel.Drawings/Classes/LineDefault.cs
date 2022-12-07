namespace DocumentModel.Drawings;

/// <summary>
/// Line Default.
/// </summary>
public class LineDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, LineDefault
{
  public override ShapeProperties6? ShapeProperties
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
  
  public override ShapeStyle2? ShapeStyle
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
