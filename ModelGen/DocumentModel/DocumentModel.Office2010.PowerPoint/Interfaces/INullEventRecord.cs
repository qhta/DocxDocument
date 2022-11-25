namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the NullEventRecord Class.
/// </summary>
public interface INullEventRecord // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? ObjectId { get ; set; }
  
}
