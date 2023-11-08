namespace DocumentModel;


/// <summary>
///   Defines the TaskCreateEventInfo Class.
/// </summary>
public partial class TaskCreateEventInfo: ModelElement<DXO21DT.TaskCreateEventInfo>
{
  public TaskCreateEventInfo(): base(){ }
  
  public TaskCreateEventInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskCreateEventInfo(DXO21DT.TaskCreateEventInfo openXmlElement): base(openXmlElement) { }
  
}
