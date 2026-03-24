namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of mail system.
/// </summary>
public enum WdMailSystem
{
  /// <summary>
  /// No mail system.
  /// </summary>
  NoMailSystem = 0,
  /// <summary>
  /// Standard Messaging Application Programming Interface (MAPI) mail system.
  /// </summary>
  MAPI = 1,
  /// <summary>
  /// PowerTalk mail system.
  /// </summary>
  PowerTalk = 2,
  /// <summary>
  /// Both a standard Messaging Application Programming Interface (MAPI) mail system and a PowerTalk mail system.
  /// </summary>
  MAPIandPowerTalk = 3
}
