namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the ThreadedCommentMentions Class.
/// </summary>
public interface IThreadedCommentMentions // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IMention>? Mentions { get ; set; }
  
}
