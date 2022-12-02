namespace DocumentModel.Drawing;

/// <summary>
/// Rich Text.
/// </summary>
public interface IRichText // : DocumentModel.Drawing.ITextBodyType
{
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IParagraph>? Paragraphs { get ; set; }
  
}
