namespace DocumentModel.Office2019.Excel.ThreadedComments;

/// <summary>
/// Defines the ThreadedCommentMentions Class.
/// </summary>
public interface IThreadedCommentMentions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Office2019.Excel.ThreadedComments.IMention>? Mentions { get ; set; }
  
}
