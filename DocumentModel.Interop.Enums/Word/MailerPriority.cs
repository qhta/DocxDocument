namespace DocumentModel.Interop.Word;

/// <summary>
/// This enumeration has been deprecated and should not be used.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdmailerpriority?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdMailerPriority")]
public enum MailerPriority
{
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPriorityNormal")]
  Normal = 1,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPriorityLow")]
  Low = 2,
  /// <summary>
  /// Not supported.
  /// </summary>
  [WordInteropEnumValue("wdPriorityHigh")]
  High = 3
}
