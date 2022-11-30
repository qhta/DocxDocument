namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Rich Text.
/// </summary>
public interface IRichText // : DocumentModel.Drawing.Charts.ITextBodyType
{
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IParagraph>? Paragraphs { get ; set; }
  
}
