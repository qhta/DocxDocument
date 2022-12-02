namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public interface IRichTextBody // : DocumentModel.Drawing.ITextBodyType
{
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
  public Collection<IParagraph>? Paragraphs { get ; set; }
  
}
