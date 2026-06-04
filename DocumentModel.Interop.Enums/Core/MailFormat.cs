namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format for an e-mail message. These formats correspond to the formats supported by Microsoft
/// Outlook for e-mail messages.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.mailformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MailFormat")]
public enum MailFormat
{
  /// <summary>
  /// Plain text.
  /// </summary>
  [OfficeInteropEnumValue("mfPlainText")]
  PlainText = 1,
  /// <summary>
  /// Hypertext Markup Language (HTML) formatting.
  /// </summary>
  [OfficeInteropEnumValue("mfHTML")]
  HTML,
  /// <summary>
  /// Rich Text Format (RTF) formatting.
  /// </summary>
  [OfficeInteropEnumValue("mfRTF")]
  RTF
}
