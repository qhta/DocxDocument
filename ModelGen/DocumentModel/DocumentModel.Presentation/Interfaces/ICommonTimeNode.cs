namespace DocumentModel.Presentation;

/// <summary>
/// Parallel TimeNode.
/// </summary>
public interface ICommonTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public UInt32? Id { get ; set; }
  
  /// <summary>
  /// presetID
  /// </summary>
  public Int32? PresetId { get ; set; }
  
  /// <summary>
  /// presetClass
  /// </summary>
  public TimeNodePresetClassKind? PresetClass { get ; set; }
  
  /// <summary>
  /// presetSubtype
  /// </summary>
  public Int32? PresetSubtype { get ; set; }
  
  /// <summary>
  /// dur
  /// </summary>
  public String? Duration { get ; set; }
  
  /// <summary>
  /// repeatCount
  /// </summary>
  public String? RepeatCount { get ; set; }
  
  /// <summary>
  /// repeatDur
  /// </summary>
  public String? RepeatDuration { get ; set; }
  
  /// <summary>
  /// spd
  /// </summary>
  public Int32? Speed { get ; set; }
  
  /// <summary>
  /// accel
  /// </summary>
  public Int32? Acceleration { get ; set; }
  
  /// <summary>
  /// decel
  /// </summary>
  public Int32? Deceleration { get ; set; }
  
  /// <summary>
  /// autoRev
  /// </summary>
  public Boolean? AutoReverse { get ; set; }
  
  /// <summary>
  /// restart
  /// </summary>
  public TimeNodeRestartKind? Restart { get ; set; }
  
  /// <summary>
  /// fill
  /// </summary>
  public TimeNodeFillKind? Fill { get ; set; }
  
  /// <summary>
  /// syncBehavior
  /// </summary>
  public TimeNodeSyncKind? SyncBehavior { get ; set; }
  
  /// <summary>
  /// tmFilter
  /// </summary>
  public String? TimeFilter { get ; set; }
  
  /// <summary>
  /// evtFilter
  /// </summary>
  public String? EventFilter { get ; set; }
  
  /// <summary>
  /// display
  /// </summary>
  public Boolean? Display { get ; set; }
  
  /// <summary>
  /// masterRel
  /// </summary>
  public TimeNodeMasterRelationKind? MasterRelation { get ; set; }
  
  /// <summary>
  /// bldLvl
  /// </summary>
  public Int32? BuildLevel { get ; set; }
  
  /// <summary>
  /// grpId
  /// </summary>
  public UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// afterEffect
  /// </summary>
  public Boolean? AfterEffect { get ; set; }
  
  /// <summary>
  /// nodeType
  /// </summary>
  public TimeNodeKind? NodeType { get ; set; }
  
  /// <summary>
  /// nodePh
  /// </summary>
  public Boolean? NodePlaceholder { get ; set; }
  
  /// <summary>
  /// presetBounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public Int32? PresetBounceEnd { get ; set; }
  
  /// <summary>
  /// StartConditionList.
  /// </summary>
  public IStartConditionList? StartConditionList { get ; set; }
  
  /// <summary>
  /// EndConditionList.
  /// </summary>
  public IEndConditionList? EndConditionList { get ; set; }
  
  /// <summary>
  /// EndSync.
  /// </summary>
  public IEndSync? EndSync { get ; set; }
  
  /// <summary>
  /// Iterate.
  /// </summary>
  public IIterate? Iterate { get ; set; }
  
  /// <summary>
  /// ChildTimeNodeList.
  /// </summary>
  public IChildTimeNodeList? ChildTimeNodeList { get ; set; }
  
  /// <summary>
  /// SubTimeNodeList.
  /// </summary>
  public ISubTimeNodeList? SubTimeNodeList { get ; set; }
  
}
