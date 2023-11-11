namespace DocumentModel;


/// <summary>
///   Defines the TaskAnchor Class.
/// </summary>
public partial class TaskAnchor: ModelElement<DXO21DT.TaskAnchor>
{
  public TaskAnchor(): base(){ }
  
  public TaskAnchor(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskAnchor(DXO21DT.TaskAnchor openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   CommentAnchor.
  /// </summary>
  [DataMember]
  public DM.CommentAnchor? CommentAnchor
  {
    get
    {
      return _Element?.GetObject<DM.CommentAnchor,DXO21DT.CommentAnchor>();
    }
    set
    {
      _ExistingElement.SetObject<DM.CommentAnchor,DXO21DT.CommentAnchor>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DM.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DM.ExtensionList,DXO21DT.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DM.ExtensionList,DXO21DT.ExtensionList>(value);
    }
  }
  
}
