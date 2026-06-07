namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of mail system.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailsystem?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdMailSystem")]
public enum MailSystem
{
  /// <summary>
  /// No mail system.
  /// </summary>
  [InteropEnumValue("wdNoMailSystem")]
  NoMailSystem = 0,
  /// <summary>
  /// Standard Messaging Application Programming Interface (MAPI) mail system.
  /// </summary>
  [InteropEnumValue("wdMAPI")]
  MAPI = 1,
  /// <summary>
  /// PowerTalk mail system.
  /// </summary>
  [InteropEnumValue("wdPowerTalk")]
  PowerTalk = 2,
  /// <summary>
  /// Both a standard Messaging Application Programming Interface (MAPI) mail system and a PowerTalk mail system.
  /// </summary>
  [InteropEnumValue("wdMAPIandPowerTalk")]
  MAPIandPowerTalk = 3
}
