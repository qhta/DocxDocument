namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TriggerEventRecord Class.
/// </summary>
public interface ITriggerEventRecord // : DocumentModel.ITypedOpenXmlLeafElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Presentation.TriggerEventKind? Type { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.UInt32? ObjectId { get ; set; }
  
}
