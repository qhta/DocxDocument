namespace DocumentModel.Drawings;

/// <summary>
/// Text Default.
/// </summary>
public class TextDefaultImpl: DocumentModel.Drawings.DefaultShapeDefinitionTypeImpl, TextDefault
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
