namespace DocumentModel;


/// <summary>
///   Defines the TaskDeleteEventInfo Class.
/// </summary>
public partial class TaskDeleteEventInfo: ModelElement<DXO21DT.TaskDeleteEventInfo>
{
  public TaskDeleteEventInfo(): base(){ }
  
  public TaskDeleteEventInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskDeleteEventInfo(DXO21DT.TaskDeleteEventInfo openXmlElement): base(openXmlElement) { }
  
}
