namespace DocumentModel.Presentation;

/// <summary>
/// Defines the TriggerEventRecord Class.
/// </summary>
public interface TriggerEventRecord // : System.Boolean
{
  /// <summary>
  /// type, this property is only available in Office 2010 and later.
  /// </summary>
  public TriggerEventKind? Type { get ; set; }
  
  /// <summary>
  /// time, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Time { get ; set; }
  
  /// <summary>
  /// objId, this property is only available in Office 2010 and later.
  /// </summary>
  public UInt32? ObjectId { get ; set; }
  
}
