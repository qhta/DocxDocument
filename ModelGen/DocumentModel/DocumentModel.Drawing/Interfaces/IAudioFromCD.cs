namespace DocumentModel.Drawing;

/// <summary>
/// Audio from CD.
/// </summary>
public interface IAudioFromCD // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public DocumentModel.Drawing.IAudioCDTimeType? StartTime { get ; set; }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public DocumentModel.Drawing.IAudioCDTimeType? EndTime { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? ExtensionList { get ; set; }
  
}
