namespace DocumentModel.Presentation;

/// <summary>
/// Parallel TimeNode.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.IChildTimeNodeList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.ISubTimeNodeList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IIterate))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IEndSync))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IStartConditionList))]
[ChildElementInfo(typeof(DocumentModel.Presentation.IEndConditionList))]
public class CommonTimeNode: ICommonTimeNode
{
  /// <summary>
  /// id
  /// </summary>
  public uint? Id
  {
    get;
    set;
  }
  
  /// <summary>
  /// presetID
  /// </summary>
  public int? PresetId
  {
    get;
    set;
  }
  
  /// <summary>
  /// presetClass
  /// </summary>
  public TimeNodePresetClassValues? PresetClass
  {
    get;
    set;
  }
  
  /// <summary>
  /// presetSubtype
  /// </summary>
  public int? PresetSubtype
  {
    get;
    set;
  }
  
  /// <summary>
  /// dur
  /// </summary>
  public string? Duration
  {
    get;
    set;
  }
  
  /// <summary>
  /// repeatCount
  /// </summary>
  public string? RepeatCount
  {
    get;
    set;
  }
  
  /// <summary>
  /// repeatDur
  /// </summary>
  public string? RepeatDuration
  {
    get;
    set;
  }
  
  /// <summary>
  /// spd
  /// </summary>
  public int? Speed
  {
    get;
    set;
  }
  
  /// <summary>
  /// accel
  /// </summary>
  public int? Acceleration
  {
    get;
    set;
  }
  
  /// <summary>
  /// decel
  /// </summary>
  public int? Deceleration
  {
    get;
    set;
  }
  
  /// <summary>
  /// autoRev
  /// </summary>
  public bool? AutoReverse
  {
    get;
    set;
  }
  
  /// <summary>
  /// restart
  /// </summary>
  public TimeNodeRestartValues? Restart
  {
    get;
    set;
  }
  
  /// <summary>
  /// fill
  /// </summary>
  public TimeNodeFillValues? Fill
  {
    get;
    set;
  }
  
  /// <summary>
  /// syncBehavior
  /// </summary>
  public TimeNodeSyncValues? SyncBehavior
  {
    get;
    set;
  }
  
  /// <summary>
  /// tmFilter
  /// </summary>
  public string? TimeFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// evtFilter
  /// </summary>
  public string? EventFilter
  {
    get;
    set;
  }
  
  /// <summary>
  /// display
  /// </summary>
  public bool? Display
  {
    get;
    set;
  }
  
  /// <summary>
  /// masterRel
  /// </summary>
  public TimeNodeMasterRelationValues? MasterRelation
  {
    get;
    set;
  }
  
  /// <summary>
  /// bldLvl
  /// </summary>
  public int? BuildLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// grpId
  /// </summary>
  public uint? GroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// afterEffect
  /// </summary>
  public bool? AfterEffect
  {
    get;
    set;
  }
  
  /// <summary>
  /// nodeType
  /// </summary>
  public TimeNodeValues? NodeType
  {
    get;
    set;
  }
  
  /// <summary>
  /// nodePh
  /// </summary>
  public bool? NodePlaceholder
  {
    get;
    set;
  }
  
  /// <summary>
  /// presetBounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public int? PresetBounceEnd
  {
    get;
    set;
  }
  
  /// <summary>
  /// StartConditionList.
  /// </summary>
  public IStartConditionList? StartConditionList
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndConditionList.
  /// </summary>
  public IEndConditionList? EndConditionList
  {
    get;
    set;
  }
  
  /// <summary>
  /// EndSync.
  /// </summary>
  public IEndSync? EndSync
  {
    get;
    set;
  }
  
  /// <summary>
  /// Iterate.
  /// </summary>
  public IIterate? Iterate
  {
    get;
    set;
  }
  
  /// <summary>
  /// ChildTimeNodeList.
  /// </summary>
  public IChildTimeNodeList? ChildTimeNodeList
  {
    get;
    set;
  }
  
  /// <summary>
  /// SubTimeNodeList.
  /// </summary>
  public ISubTimeNodeList? SubTimeNodeList
  {
    get;
    set;
  }
  
}
