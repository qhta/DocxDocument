namespace DocumentModel;


/// <summary>
///   Defines the TaskTitleEventInfo Class.
/// </summary>
public partial class TaskTitleEventInfo
{
  
  /// <summary>
  ///   title, this property is only available in Office 2021 and later.
  /// </summary>
  [SchemaAttr("title")]
  public String? Title { get; set; }
  
}
