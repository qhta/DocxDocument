namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the type of mail system.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailsystem?view=office-pia` for Office interop details.
/// </remarks>
public enum MailSystem
{
  /// <summary>
  /// No mail system.
  /// </summary>
  NoMailSystem = 0,
  /// <summary>
  /// Standard Messaging IApplication Programming Interface (MAPI) mail system.
  /// </summary>
  MAPI = 1,
  /// <summary>
  /// PowerTalk mail system.
  /// </summary>
  PowerTalk = 2,
  /// <summary>
  /// Both a standard Messaging IApplication Programming Interface (MAPI) mail system and a PowerTalk mail system.
  /// </summary>
  MAPIandPowerTalk = 3
}

