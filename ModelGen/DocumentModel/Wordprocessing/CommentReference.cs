namespace DocumentModel.Wordprocessing;


/// <summary>
///   Comment Content Reference Mark.
/// </summary>
public partial class CommentReference: ModelElement<DXW.CommentReference>
{
  public CommentReference(): base(){ }
  
  public CommentReference(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentReference(DXW.CommentReference openXmlElement): base(openXmlElement) { }
  
}
