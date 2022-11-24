namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the NullEventRecord Class.
/// </summary>
public interface INullEventRecord // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ObjectId { get ; set; }
  
}
