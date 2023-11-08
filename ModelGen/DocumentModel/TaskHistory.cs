namespace DocumentModel;


/// <summary>
///   Defines the TaskHistory Class.
/// </summary>
public partial class TaskHistory: ModelElement<DXO21DT.TaskHistory>
{
  public TaskHistory(): base(){ }
  
  public TaskHistory(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskHistory(DXO21DT.TaskHistory openXmlElement): base(openXmlElement) { }
  
}
