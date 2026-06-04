namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodatetimeformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoDateTimeFormat")]
public enum DateTimeFormat
{
  /// <summary>
  /// Specifies a mixed format.
  /// </summary>
  [InteropEnumValue("msoDateTimeFormatMixed")]
  FormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimeMdyy")]
  Mdyy = 1,
  /// <summary>
  /// Specifies a ddddMMMMddyyyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimeddddMMMMddyyyy")]
  ddddMMMMddyyyy = 2,
  /// <summary>
  /// Specifies MMMMyyyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimedMMMMyyyy")]
  MMMMyyyy = 3,
  /// <summary>
  /// Specifies a MMMMdyyyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimeMMMMdyyyy")]
  MMMMdyyyy = 4,
  /// <summary>
  /// Specifies MMMyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimedMMMyy")]
  MMMyy = 5,
  /// <summary>
  /// Specifies a MMMMyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimeMMMMyy")]
  MMMMyy = 6,
  /// <summary>
  /// Specifies a MMyy format.
  /// </summary>
  [InteropEnumValue("msoDateTimeMMyy")]
  MMyy = 7,
  /// <summary>
  /// Specifies a MMddyyHmm format.
  /// </summary>
  [InteropEnumValue("msoDateTimeMMddyyHmm")]
  MMddyyHmm = 8,
  /// <summary>
  /// Specifies a MMddyyhmmAMPM format.
  /// </summary>
  [InteropEnumValue("msoDateTimeMMddyyhmmAMPM")]
  MMddyyhmmAMPM = 9,
  /// <summary>
  /// Specifies Hmm format.
  /// </summary>
  [InteropEnumValue("msoDateTimeHmm")]
  Hmm = 10,
  /// <summary>
  /// Specifies a Hmmss format.
  /// </summary>
  [InteropEnumValue("msoDateTimeHmmss")]
  Hmmss = 11,
  /// <summary>
  /// Specifies a hmmAMPM format.
  /// </summary>
  [InteropEnumValue("msoDateTimehmmAMPM")]
  hmmAMPM = 12,
  /// <summary>
  /// Specifies a hmmssAMPM format.
  /// </summary>
  [InteropEnumValue("msoDateTimehmmssAMPM")]
  hmmssAMPM = 13,
  /// <summary>
  /// Specifies that the Office application will determine the format.
  /// </summary>
  [InteropEnumValue("msoDateTimeFigureOut")]
  FigureOut = 14
}
