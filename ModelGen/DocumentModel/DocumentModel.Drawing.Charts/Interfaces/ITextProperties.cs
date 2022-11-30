namespace DocumentModel.Drawing.Charts;

/// <summary>
/// Defines the TextProperties Class.
/// </summary>
public interface ITextProperties // : DocumentModel.Drawing.Charts.ITextBodyType
{
  public DocumentModel.Drawing.IBodyProperties? BodyProperties { get ; set; }
  
  public DocumentModel.Drawing.IListStyle? ListStyle { get ; set; }
  
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IParagraph>? Paragraphs { get ; set; }
  
}
