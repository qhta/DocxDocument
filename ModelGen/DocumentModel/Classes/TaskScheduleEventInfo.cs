namespace DocumentModel;


/// <summary>
///   Defines the TaskScheduleEventInfo Class.
/// </summary>
public partial class TaskScheduleEventInfo
{
  
  /// <summary>
  ///   startDate, this property is only available in Office 2021 and later.
  /// </summary>
  [SchemaAttr("startDate")]
  public DateTime? StartDate { get; set; }
  
  
  /// <summary>
  ///   dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  [SchemaAttr("dueDate")]
  public DateTime? DueDate { get; set; }
  
}
