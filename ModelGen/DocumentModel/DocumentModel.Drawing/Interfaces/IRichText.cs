namespace DocumentModel.Drawing;

/// <summary>
/// Rich Text.
/// </summary>
public interface IRichText // : DocumentModel.Drawing.ITextBodyType
{
  public IBodyProperties? BodyProperties { get ; set; }
  
  public IListStyle? ListStyle { get ; set; }
  
  public Collection<IParagraph>? Paragraphs { get ; set; }
  
}
