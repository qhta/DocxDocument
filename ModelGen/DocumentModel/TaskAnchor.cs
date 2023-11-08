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
      var element = _Element?.GetFirstChild<DXO21DT.CommentAnchor>();
      if (element != null)
        return CommentAnchorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.CommentAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CommentAnchorConverter.CreateOpenXmlElement<DXO21DT.CommentAnchor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO21DT.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXO21DT.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
