namespace DocumentModel.Drawing;

/// <summary>
/// Audio from CD.
/// </summary>
public interface IAudioFromCD // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public IStartTime? StartTime { get ; set; }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public IEndTime? EndTime { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public IExtensionList? ExtensionList { get ; set; }
  
}
