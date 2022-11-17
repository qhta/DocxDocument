namespace DocumentModel.Office2021.DocumentTasks;

public interface ITaskAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2021.DocumentTasks.ICommentAnchor? CommentAnchor { get ; set; }

  public DocumentModel.Office2021.DocumentTasks.IExtensionList? ExtensionList { get ; set; }

}
