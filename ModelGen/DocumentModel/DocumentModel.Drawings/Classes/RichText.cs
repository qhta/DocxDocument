namespace DocumentModel.Drawings;

/// <summary>
/// Rich Text.
/// </summary>
public class RichText: DocumentModel.Drawings.TextBodyType1
{
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
  
}
