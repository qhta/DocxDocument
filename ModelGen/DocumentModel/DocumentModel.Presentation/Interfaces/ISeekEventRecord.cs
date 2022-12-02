namespace DocumentModel.Presentation;

/// <summary>
/// Defines the SeekEventRecord Class.
/// </summary>
public interface ISeekEventRecord // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? ObjectId { get ; set; }
  
  /// <summary>
  /// seek, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Seek { get ; set; }
  
}
