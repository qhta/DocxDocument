namespace DocumentModel.Drawing;

/// <summary>
/// Defines the RichTextBody Class.
/// </summary>
public interface IRichTextBody // : DocumentModel.Drawing.ITextBodyType
{
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IParagraph>? Paragraphs { get ; set; }
  
}
