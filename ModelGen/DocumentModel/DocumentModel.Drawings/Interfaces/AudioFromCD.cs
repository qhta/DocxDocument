namespace DocumentModel.Drawings;

/// <summary>
/// Audio from CD.
/// </summary>
public partial interface AudioFromCD
{
  /// <summary>
  /// Audio Start Time.
  /// </summary>
  public DocumentModel.Drawings.AudioCDTimeType? StartTime { get; set; }
  
  /// <summary>
  /// Audio End Time.
  /// </summary>
  public DocumentModel.Drawings.AudioCDTimeType? EndTime { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
