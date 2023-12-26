namespace DocumentModel;


/// <summary>
///   Defines the Tasks Class.
/// </summary>
public partial class Tasks: ModelElement<DXO21DT.Tasks>
{
  public Tasks(): base(){ }
  
  public Tasks(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Tasks(DXO21DT.Tasks openXmlElement): base(openXmlElement) { }
  
}
