namespace DocumentModel.Presentation;

public interface ICommonTimeNode // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public uint? Id { get ; set; }

  public int? PresetId { get ; set; }

  public TimeNodePresetClass? PresetClass { get ; set; }

  public int? PresetSubtype { get ; set; }

  public string? Duration { get ; set; }

  public string? RepeatCount { get ; set; }

  public string? RepeatDuration { get ; set; }

  public int? Speed { get ; set; }

  public int? Acceleration { get ; set; }

  public int? Deceleration { get ; set; }

  public bool? AutoReverse { get ; set; }

  public TimeNodeRestart? Restart { get ; set; }

  public TimeNodeFill? Fill { get ; set; }

  public TimeNodeSync? SyncBehavior { get ; set; }

  public string? TimeFilter { get ; set; }

  public string? EventFilter { get ; set; }

  public bool? Display { get ; set; }

  public TimeNodeMasterRelation? MasterRelation { get ; set; }

  public int? BuildLevel { get ; set; }

  public uint? GroupId { get ; set; }

  public bool? AfterEffect { get ; set; }

  public TimeNode? NodeType { get ; set; }

  public bool? NodePlaceholder { get ; set; }

  public int? PresetBounceEnd { get ; set; }

  public IStartConditionList? StartConditionList { get ; set; }

  public IEndConditionList? EndConditionList { get ; set; }

  public IEndSync? EndSync { get ; set; }

  public IIterate? Iterate { get ; set; }

  public IChildTimeNodeList? ChildTimeNodeList { get ; set; }

  public ISubTimeNodeList? SubTimeNodeList { get ; set; }

}
