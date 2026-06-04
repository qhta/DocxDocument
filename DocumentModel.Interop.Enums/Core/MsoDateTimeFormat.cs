namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodatetimeformat?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType(typeof(Microsoft.Office.Core.MsoDateTimeFormat))]
public enum DateTimeFormat
{
  /// <summary>
  /// Specifies a mixed format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeFormatMixed))]
  FormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeMdyy))]
  Mdyy = 1,
  /// <summary>
  /// Specifies a ddddMMMMddyyyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeddddMMMMddyyyy))]
  ddddMMMMddyyyy = 2,
  /// <summary>
  /// Specifies MMMMyyyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimedMMMMyyyy))]
  MMMMyyyy = 3,
  /// <summary>
  /// Specifies a MMMMdyyyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeMMMMdyyyy))]
  MMMMdyyyy = 4,
  /// <summary>
  /// Specifies MMMyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimedMMMyy))]
  MMMyy = 5,
  /// <summary>
  /// Specifies a MMMMyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeMMMMyy))]
  MMMMyy = 6,
  /// <summary>
  /// Specifies a MMyy format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeMMyy))]
  MMyy = 7,
  /// <summary>
  /// Specifies a MMddyyHmm format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeMMddyyHmm))]
  MMddyyHmm = 8,
  /// <summary>
  /// Specifies a MMddyyhmmAMPM format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeMMddyyhmmAMPM))]
  MMddyyhmmAMPM = 9,
  /// <summary>
  /// Specifies Hmm format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeHmm))]
  Hmm = 10,
  /// <summary>
  /// Specifies a Hmmss format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeHmmss))]
  Hmmss = 11,
  /// <summary>
  /// Specifies a hmmAMPM format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimehmmAMPM))]
  hmmAMPM = 12,
  /// <summary>
  /// Specifies a hmmssAMPM format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimehmmssAMPM))]
  hmmssAMPM = 13,
  /// <summary>
  /// Specifies that the Office application will determine the format.
  /// </summary>
  [OfficeInteropEnumValue(nameof(Microsoft.Office.Core.MsoDateTimeFormat.msoDateTimeFigureOut))]
  FigureOut = 14
}
