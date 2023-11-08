namespace DocumentModel;


/// <summary>
///   Defines the TaskHistoryEvent Class.
/// </summary>
public partial class TaskHistoryEvent: ModelElement<DXO21DT.TaskHistoryEvent>
{
  public TaskHistoryEvent(): base(){ }
  
  public TaskHistoryEvent(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskHistoryEvent(DXO21DT.TaskHistoryEvent openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   time, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DateTime? Time
  {
    get
    {
      return _Element?.Time?.Value;
    }
    set
    {
      _ExistingElement.Time = value;
    }
  }
  
  
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
  ///   AttributionTaskUser.
  /// </summary>
  [DataMember]
  public DM.AttributionTaskUser? AttributionTaskUser
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.AttributionTaskUser>();
      if (element != null)
        return AttributionTaskUserConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.AttributionTaskUser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AttributionTaskUserConverter.CreateOpenXmlElement<DXO21DT.AttributionTaskUser>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
  
  [DataMember]
  public DM.AssignTaskUser? AssignTaskUser
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.AssignTaskUser>();
      if (element != null)
        return AssignTaskUserConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.AssignTaskUser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AssignTaskUserConverter.CreateOpenXmlElement<DXO21DT.AssignTaskUser>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.UnassignTaskUser? UnassignTaskUser
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.UnassignTaskUser>();
      if (element != null)
        return UnassignTaskUserConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.UnassignTaskUser>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = UnassignTaskUserConverter.CreateOpenXmlElement<DXO21DT.UnassignTaskUser>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskCreateEventInfo? TaskCreateEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskCreateEventInfo>();
      if (element != null)
        return TaskCreateEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskCreateEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskCreateEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskCreateEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskTitleEventInfo? TaskTitleEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskTitleEventInfo>();
      if (element != null)
        return TaskTitleEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskTitleEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskTitleEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskTitleEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskScheduleEventInfo? TaskScheduleEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskScheduleEventInfo>();
      if (element != null)
        return TaskScheduleEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskScheduleEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskScheduleEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskScheduleEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskProgressEventInfo? TaskProgressEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskProgressEventInfo>();
      if (element != null)
        return TaskProgressEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskProgressEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskProgressEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskProgressEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskPriorityEventInfo? TaskPriorityEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskPriorityEventInfo>();
      if (element != null)
        return TaskPriorityEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskPriorityEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskPriorityEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskPriorityEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskDeleteEventInfo? TaskDeleteEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskDeleteEventInfo>();
      if (element != null)
        return TaskDeleteEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskDeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskDeleteEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskDeleteEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskUndeleteEventInfo? TaskUndeleteEventInfo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskUndeleteEventInfo>();
      if (element != null)
        return TaskUndeleteEventInfoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskUndeleteEventInfo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskUndeleteEventInfoConverter.CreateOpenXmlElement<DXO21DT.TaskUndeleteEventInfo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskUnassignAll? TaskUnassignAll
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskUnassignAll>();
      if (element != null)
        return TaskUnassignAllConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskUnassignAll>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskUnassignAllConverter.CreateOpenXmlElement<DXO21DT.TaskUnassignAll>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DM.TaskUndo? TaskUndo
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DT.TaskUndo>();
      if (element != null)
        return TaskUndoConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DT.TaskUndo>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TaskUndoConverter.CreateOpenXmlElement<DXO21DT.TaskUndo>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
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
