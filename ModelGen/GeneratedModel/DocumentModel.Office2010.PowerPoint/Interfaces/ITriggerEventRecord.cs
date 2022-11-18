namespace DocumentModel.Office2010.PowerPoint;

/// <summary>
/// Defines the TriggerEventRecord Class.
/// </summary>
public interface ITriggerEventRecord // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public TriggerEvent? Type { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public uint? ObjectId { get ; set; }
  
}
