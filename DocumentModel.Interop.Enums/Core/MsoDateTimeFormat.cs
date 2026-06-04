namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodatetimeformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoDateTimeFormat")]
public enum DateTimeFormat
{
  /// <summary>
  /// Specifies a mixed format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeFormatMixed")]
  FormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeMdyy")]
  Mdyy = 1,
  /// <summary>
  /// Specifies a ddddMMMMddyyyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeddddMMMMddyyyy")]
  ddddMMMMddyyyy = 2,
  /// <summary>
  /// Specifies MMMMyyyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimedMMMMyyyy")]
  MMMMyyyy = 3,
  /// <summary>
  /// Specifies a MMMMdyyyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeMMMMdyyyy")]
  MMMMdyyyy = 4,
  /// <summary>
  /// Specifies MMMyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimedMMMyy")]
  MMMyy = 5,
  /// <summary>
  /// Specifies a MMMMyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeMMMMyy")]
  MMMMyy = 6,
  /// <summary>
  /// Specifies a MMyy format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeMMyy")]
  MMyy = 7,
  /// <summary>
  /// Specifies a MMddyyHmm format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeMMddyyHmm")]
  MMddyyHmm = 8,
  /// <summary>
  /// Specifies a MMddyyhmmAMPM format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeMMddyyhmmAMPM")]
  MMddyyhmmAMPM = 9,
  /// <summary>
  /// Specifies Hmm format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeHmm")]
  Hmm = 10,
  /// <summary>
  /// Specifies a Hmmss format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeHmmss")]
  Hmmss = 11,
  /// <summary>
  /// Specifies a hmmAMPM format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimehmmAMPM")]
  hmmAMPM = 12,
  /// <summary>
  /// Specifies a hmmssAMPM format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimehmmssAMPM")]
  hmmssAMPM = 13,
  /// <summary>
  /// Specifies that the Office application will determine the format.
  /// </summary>
  [OfficeInteropEnumValue("msoDateTimeFigureOut")]
  FigureOut = 14
}
