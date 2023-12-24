namespace DocumentModel;


/// <summary>
///   Defines the CommentAnchor Class.
/// </summary>
public partial class CommentAnchor: ModelElement<DXO21DT.CommentAnchor>
{
  public CommentAnchor(): base(){ }
  
  public CommentAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public CommentAnchor(DXO21DT.CommentAnchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get => _Element?.Id;
    set => _ExistingElement.Id = value;
  }
  
}
