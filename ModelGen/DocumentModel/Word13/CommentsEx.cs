namespace DocumentModel.Word13;


/// <summary>
///   This element specifies the additional information for all of the comments defined in the current document. It is the root element of the Comments Extended Part of a WordprocessingML document.
/// </summary>
public partial class CommentsEx: ModelElement<DXO13W.CommentsEx>
{
  public CommentsEx(): base(){ }
  
  public CommentsEx(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentsEx(DXO13W.CommentsEx openXmlElement): base(openXmlElement) { }
  
}
