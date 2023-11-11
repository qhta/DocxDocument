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
      return _Element?.GetObject<DM.AttributionTaskUser,DXO21DT.AttributionTaskUser>();
    }
    set
    {
      _ExistingElement.SetObject<DM.AttributionTaskUser,DXO21DT.AttributionTaskUser>(value);
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
      return _Element?.GetObject<DM.TaskAnchor,DXO21DT.TaskAnchor>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskAnchor,DXO21DT.TaskAnchor>(value);
    }
  }
  
  [DataMember]
  public DM.AssignTaskUser? AssignTaskUser
  {
    get
    {
      return _Element?.GetObject<DM.AssignTaskUser,DXO21DT.AssignTaskUser>();
    }
    set
    {
      _ExistingElement.SetObject<DM.AssignTaskUser,DXO21DT.AssignTaskUser>(value);
    }
  }
  
  [DataMember]
  public DM.UnassignTaskUser? UnassignTaskUser
  {
    get
    {
      return _Element?.GetObject<DM.UnassignTaskUser,DXO21DT.UnassignTaskUser>();
    }
    set
    {
      _ExistingElement.SetObject<DM.UnassignTaskUser,DXO21DT.UnassignTaskUser>(value);
    }
  }
  
  [DataMember]
  public DM.TaskCreateEventInfo? TaskCreateEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskCreateEventInfo,DXO21DT.TaskCreateEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskCreateEventInfo,DXO21DT.TaskCreateEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskTitleEventInfo? TaskTitleEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskTitleEventInfo,DXO21DT.TaskTitleEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskTitleEventInfo,DXO21DT.TaskTitleEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskScheduleEventInfo? TaskScheduleEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskScheduleEventInfo,DXO21DT.TaskScheduleEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskScheduleEventInfo,DXO21DT.TaskScheduleEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskProgressEventInfo? TaskProgressEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskProgressEventInfo,DXO21DT.TaskProgressEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskProgressEventInfo,DXO21DT.TaskProgressEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskPriorityEventInfo? TaskPriorityEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskPriorityEventInfo,DXO21DT.TaskPriorityEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskPriorityEventInfo,DXO21DT.TaskPriorityEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskDeleteEventInfo? TaskDeleteEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskDeleteEventInfo,DXO21DT.TaskDeleteEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskDeleteEventInfo,DXO21DT.TaskDeleteEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskUndeleteEventInfo? TaskUndeleteEventInfo
  {
    get
    {
      return _Element?.GetObject<DM.TaskUndeleteEventInfo,DXO21DT.TaskUndeleteEventInfo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskUndeleteEventInfo,DXO21DT.TaskUndeleteEventInfo>(value);
    }
  }
  
  [DataMember]
  public DM.TaskUnassignAll? TaskUnassignAll
  {
    get
    {
      return _Element?.GetObject<DM.TaskUnassignAll,DXO21DT.TaskUnassignAll>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskUnassignAll,DXO21DT.TaskUnassignAll>(value);
    }
  }
  
  [DataMember]
  public DM.TaskUndo? TaskUndo
  {
    get
    {
      return _Element?.GetObject<DM.TaskUndo,DXO21DT.TaskUndo>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskUndo,DXO21DT.TaskUndo>(value);
    }
  }
  
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
