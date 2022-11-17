namespace DocumentModel.Office.PowerPoint.Y2021.M06.Main;

public interface ITaskAnchor // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public DocumentModel.Office.PowerPoint.Y2021.M06.Main.ICommentAnchor? CommentAnchor { get ; set; }

  public DocumentModel.Office.PowerPoint.Y2021.M06.Main.IExtensionList? ExtensionList { get ; set; }

}
