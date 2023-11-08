namespace DocumentModel;


/// <summary>
///   Defines the TaskScheduleEventInfo Class.
/// </summary>
public partial class TaskScheduleEventInfo: ModelElement<DXO21DT.TaskScheduleEventInfo>
{
  public TaskScheduleEventInfo(): base(){ }
  
  public TaskScheduleEventInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskScheduleEventInfo(DXO21DT.TaskScheduleEventInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   startDate, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DateTime? StartDate
  {
    get
    {
      return _Element?.StartDate?.Value;
    }
    set
    {
      _ExistingElement.StartDate = value;
    }
  }
  
  
  /// <summary>
  ///   dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DateTime? DueDate
  {
    get
    {
      return _Element?.DueDate?.Value;
    }
    set
    {
      _ExistingElement.DueDate = value;
    }
  }
  
}
