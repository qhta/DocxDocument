namespace DocumentModel;


/// <summary>
///   Defines the TaskTitleEventInfo Class.
/// </summary>
public partial class TaskTitleEventInfo: ModelElement<DXO21DT.TaskTitleEventInfo>
{
  public TaskTitleEventInfo(): base(){ }
  
  public TaskTitleEventInfo(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TaskTitleEventInfo(DXO21DT.TaskTitleEventInfo openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   title, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public String? Title
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Title);
    }
    set
    {
      _ExistingElement.Title = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
