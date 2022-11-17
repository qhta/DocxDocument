namespace DocumentModel.Presentation;

public interface ITextElement // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public ICharRange? CharRange { get ; set; }
  
  public IParagraphIndexRange? ParagraphIndexRange { get ; set; }
  
}
