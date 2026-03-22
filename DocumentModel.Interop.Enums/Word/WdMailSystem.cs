namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of mail system.
/// </summary>
public enum WdMailSystem
{
  /// <summary>
  /// No mail system.
  /// </summary>
  wdNoMailSystem = unchecked((int)0),
  /// <summary>
  /// Standard Messaging Application Programming Interface (MAPI) mail system.
  /// </summary>
  wdMAPI = unchecked((int)1),
  /// <summary>
  /// PowerTalk mail system.
  /// </summary>
  wdPowerTalk = unchecked((int)2),
  /// <summary>
  /// Both a standard Messaging Application Programming Interface (MAPI) mail system and a PowerTalk mail system.
  /// </summary>
  wdMAPIandPowerTalk = unchecked((int)3)
}
