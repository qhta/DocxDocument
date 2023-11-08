namespace DocumentModel;


/// <summary>
///   Defines the TaskPriorityEventInfo Class.
/// </summary>
public partial class TaskPriorityEventInfo: ModelElement<DXO21DT.TaskPriorityEventInfo>
{
  public TaskPriorityEventInfo(): base(){ }
  
  public TaskPriorityEventInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskPriorityEventInfo(DXO21DT.TaskPriorityEventInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   value, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public Int32? Value
  {
    get
    {
      return _Element?.Value?.Value;
    }
    set
    {
      _ExistingElement.Value = value;
    }
  }
  
}
