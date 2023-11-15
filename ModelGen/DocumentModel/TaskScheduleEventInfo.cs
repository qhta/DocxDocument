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
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
  
  /// <summary>
  ///   dueDate, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public DateTime? DueDate
  {
    get => throw new NotImplementedException("Not implemented in GeneratePropertyGetter: targetPropType baseType is System.ValueType");
    set => throw new NotImplementedException("Not implemented in GeneratePropertySetter: targetPropType baseType is System.ValueType");
  }
  
}
