namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public class TextProperties1: DocumentModel.Drawings.TextBodyType1
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
