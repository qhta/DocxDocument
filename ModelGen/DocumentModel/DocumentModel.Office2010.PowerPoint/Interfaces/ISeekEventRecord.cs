namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SeekEventRecord Class.
/// </summary>
public interface ISeekEventRecord // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ObjectId { get ; set; }
  
  /// <summary>
  /// seek, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Seek { get ; set; }
  
}
