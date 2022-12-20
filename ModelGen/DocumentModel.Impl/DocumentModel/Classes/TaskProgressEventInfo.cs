namespace DocumentModel;

/// <summary>
/// Defines the TaskProgressEventInfo Class.
/// </summary>
public partial class TaskProgressEventInfoImpl: ModelElementImpl, TaskProgressEventInfo
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public TaskProgressEventInfoImpl(): base() {}
  
  public TaskProgressEventInfoImpl(DocumentFormat.OpenXml.Office2021.DocumentTasks.TaskProgressEventInfo openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// percentComplete, this property is only available in Office 2021 and later.
  /// </summary>
  public Int32? PercentComplete
  {
    get => (System.Int32?)OpenXmlElement?.PercentComplete?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.PercentComplete = (System.Int32?)value;
    }
  }
  
}
