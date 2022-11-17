namespace DocumentModel.Office2021.PowerPoint.Tasks;

public interface ITaskAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office2021.PowerPoint.Tasks.ICommentAnchor? CommentAnchor { get ; set; }

  public DocumentModel.Office2021.PowerPoint.Tasks.IExtensionList? ExtensionList { get ; set; }

}
