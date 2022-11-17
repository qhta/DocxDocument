namespace DocumentModel.Office2016.Excel;

public interface IComments // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IAuthors? Authors { get ; set; }

  public DocumentModel.Spreadsheet.ICommentList? CommentList { get ; set; }

  public DocumentModel.Spreadsheet.IExtensionList? ExtensionList { get ; set; }

}
