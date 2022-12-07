namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public class RichTextBodyImpl: DocumentModel.Drawings.TextBodyType2Impl, RichTextBody
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
