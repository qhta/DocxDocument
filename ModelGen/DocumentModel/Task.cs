namespace DocumentModel;


/// <summary>
///   Defines the Task Class.
/// </summary>
public partial class Task: ModelElement<DXO21DT.Task>
{
  public Task(): base(){ }
  
  public Task(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Task(DXO21DT.Task openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   TaskAnchor.
  /// </summary>
  [DataMember]
  public DM.TaskAnchor? TaskAnchor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskAnchor>();
      if (element != null)
        return TaskAnchorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskAnchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskAnchorConverter.CreateOpenXmlElement<DXO21DT.TaskAnchor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TaskHistory.
  /// </summary>
  [DataMember]
  public DM.TaskHistory? TaskHistory
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskHistory>();
      if (element != null)
        return TaskHistoryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskHistory>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskHistoryConverter.CreateOpenXmlElement<DXO21DT.TaskHistory>(value);
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
