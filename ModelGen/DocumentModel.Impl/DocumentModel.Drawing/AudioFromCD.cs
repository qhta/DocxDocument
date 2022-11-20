namespace DocumentModel.Drawing;

/// <summary>
/// Audio from CD.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Drawing.IStartTime))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IEndTime))]
[ChildElementInfo(typeof(DocumentModel.Drawing.IExtensionList))]
public class AudioFromCD: IAudioFromCD
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public IStartTime? StartTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public IEndTime? EndTime
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IExtensionList? ExtensionList
  {
    get;
    set;
  }
  
}
