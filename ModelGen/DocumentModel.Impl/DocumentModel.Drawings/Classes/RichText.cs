namespace DocumentModel.Drawings;

/// <summary>
/// Rich Text.
/// </summary>
public class RichTextImpl: DocumentModel.Drawings.TextBodyType1Impl, RichText
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
