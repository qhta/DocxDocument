namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedCommentMentions Class.
/// </summary>
public interface IThreadedCommentMentions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Spreadsheet.IMention>? Mentions { get ; set; }
  
}
