namespace DocumentModel.Presentation;

/// <summary>
/// Parallel TimeNode.
/// </summary>
public interface ICommonTimeNode // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id
  /// </summary>
  public System.UInt32? Id { get ; set; }
  
  /// <summary>
  /// presetID
  /// </summary>
  public System.Int32? PresetId { get ; set; }
  
  /// <summary>
  /// presetClass
  /// </summary>
  public DocumentModel.Presentation.TimeNodePresetClassKind? PresetClass { get ; set; }
  
  /// <summary>
  /// presetSubtype
  /// </summary>
  public System.Int32? PresetSubtype { get ; set; }
  
  /// <summary>
  /// dur
  /// </summary>
  public System.String? Duration { get ; set; }
  
  /// <summary>
  /// repeatCount
  /// </summary>
  public System.String? RepeatCount { get ; set; }
  
  /// <summary>
  /// repeatDur
  /// </summary>
  public System.String? RepeatDuration { get ; set; }
  
  /// <summary>
  /// spd
  /// </summary>
  public System.Int32? Speed { get ; set; }
  
  /// <summary>
  /// accel
  /// </summary>
  public System.Int32? Acceleration { get ; set; }
  
  /// <summary>
  /// decel
  /// </summary>
  public System.Int32? Deceleration { get ; set; }
  
  /// <summary>
  /// autoRev
  /// </summary>
  public System.Boolean? AutoReverse { get ; set; }
  
  /// <summary>
  /// restart
  /// </summary>
  public DocumentModel.Presentation.TimeNodeRestartKind? Restart { get ; set; }
  
  /// <summary>
  /// fill
  /// </summary>
  public DocumentModel.Presentation.TimeNodeFillKind? Fill { get ; set; }
  
  /// <summary>
  /// syncBehavior
  /// </summary>
  public DocumentModel.Presentation.TimeNodeSyncKind? SyncBehavior { get ; set; }
  
  /// <summary>
  /// tmFilter
  /// </summary>
  public System.String? TimeFilter { get ; set; }
  
  /// <summary>
  /// evtFilter
  /// </summary>
  public System.String? EventFilter { get ; set; }
  
  /// <summary>
  /// display
  /// </summary>
  public System.Boolean? Display { get ; set; }
  
  /// <summary>
  /// masterRel
  /// </summary>
  public DocumentModel.Presentation.TimeNodeMasterRelationKind? MasterRelation { get ; set; }
  
  /// <summary>
  /// bldLvl
  /// </summary>
  public System.Int32? BuildLevel { get ; set; }
  
  /// <summary>
  /// grpId
  /// </summary>
  public System.UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// afterEffect
  /// </summary>
  public System.Boolean? AfterEffect { get ; set; }
  
  /// <summary>
  /// nodeType
  /// </summary>
  public DocumentModel.Presentation.TimeNodeKind? NodeType { get ; set; }
  
  /// <summary>
  /// nodePh
  /// </summary>
  public System.Boolean? NodePlaceholder { get ; set; }
  
  /// <summary>
  /// presetBounceEnd, this property is only available in Office 2010 and later.
  /// </summary>
  public System.Int32? PresetBounceEnd { get ; set; }
  
  /// <summary>
  /// StartConditionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? StartConditionList { get ; set; }
  
  /// <summary>
  /// EndConditionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? EndConditionList { get ; set; }
  
  /// <summary>
  /// EndSync.
  /// </summary>
  public DocumentModel.Presentation.ITimeListConditionalType? EndSync { get ; set; }
  
  /// <summary>
  /// Iterate.
  /// </summary>
  public DocumentModel.Presentation.IIterate? Iterate { get ; set; }
  
  /// <summary>
  /// ChildTimeNodeList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ChildTimeNodeList { get ; set; }
  
  /// <summary>
  /// SubTimeNodeList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? SubTimeNodeList { get ; set; }
  
}
