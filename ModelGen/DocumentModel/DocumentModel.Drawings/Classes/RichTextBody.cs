namespace DocumentModel.Drawings;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public class RichTextBody: DocumentModel.Drawings.TextBodyType2
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
