namespace DocumentModel.Drawings;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public class TextProperties1Impl: DocumentModel.Drawings.TextBodyType1Impl, TextProperties1
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
