namespace DocumentModel;


/// <summary>
///   Defines the TaskProgressEventInfo Class.
/// </summary>
public partial class TaskProgressEventInfo: ModelElement<DXO21DT.TaskProgressEventInfo>
{
  public TaskProgressEventInfo(): base(){ }
  
  public TaskProgressEventInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskProgressEventInfo(DXO21DT.TaskProgressEventInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public Int32? PercentComplete
  {
    get
    {
      return _Element?.PercentComplete?.Value;
    }
    set
    {
      _ExistingElement.PercentComplete = value;
    }
  }
  
}
