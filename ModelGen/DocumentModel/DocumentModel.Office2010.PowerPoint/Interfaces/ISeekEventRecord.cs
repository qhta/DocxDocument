namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the SeekEventRecord Class.
/// </summary>
public interface ISeekEventRecord // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ObjectId { get ; set; }
  
  /// <summary>
  /// seek, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Seek { get ; set; }
  
}
