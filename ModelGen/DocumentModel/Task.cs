namespace DocumentModel;


/// <summary>
///   Defines the Task Class.
/// </summary>
public partial class Task: ModelElement<DXO21DT.Task>
{
  public Task(): base(){ }
  
  public Task(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Task(DXO21DT.Task openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   id, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   TaskAnchor.
  /// </summary>
  [DataMember]
  public DM.TaskAnchor? TaskAnchor
  {
    get
    {
      return _Element?.GetObject<DM.TaskAnchor,DXO21DT.TaskAnchor>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskAnchor,DXO21DT.TaskAnchor>(value);
    }
  }
  
  
  /// <summary>
  ///   TaskHistory.
  /// </summary>
  [DataMember]
  public DM.TaskHistory? TaskHistory
  {
    get
    {
      return _Element?.GetObject<DM.TaskHistory,DXO21DT.TaskHistory>();
    }
    set
    {
      _ExistingElement.SetObject<DM.TaskHistory,DXO21DT.TaskHistory>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DM.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DM.ExtensionList,DXO21DT.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DM.ExtensionList,DXO21DT.ExtensionList>(value);
    }
  }
  
}
