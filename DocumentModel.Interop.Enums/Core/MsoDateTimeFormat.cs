namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
public enum MsoDateTimeFormat
{
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  msoDateTimeFormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format. msoDateTimeddddMMMMddyyyy2 Specifies a ddddMMMMddyyyy format.
  /// </summary>
  msoDateTimeMdyy = 1,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  msoDateTimeddddMMMMddyyyy = 2,
  /// <summary>
  /// Specifies MMMMyyyy format.
  /// </summary>
  msoDateTimedMMMMyyyy = 3,
  /// <summary>
  /// Specifies a MMMMdyyyy format.
  /// </summary>
  msoDateTimeMMMMdyyyy = 4,
  /// <summary>
  /// Specifies MMMyy format.
  /// </summary>
  msoDateTimedMMMyy = 5,
  /// <summary>
  /// Specifies a MMMMyy format.
  /// </summary>
  msoDateTimeMMMMyy = 6,
  /// <summary>
  /// Specifies a MMyy format. msoDateTimeMMddyyHmm8 Specifies a MMddyyHmm format. msoDateTimeMMddyyhmmAMPM9
  /// Specifies a MMddyyhmmAMPM format.
  /// </summary>
  msoDateTimeMMyy = 7,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  msoDateTimeMMddyyHmm = 8,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  msoDateTimeMMddyyhmmAMPM = 9,
  /// <summary>
  /// Specifies Hmm format.
  /// </summary>
  msoDateTimeHmm = 10,
  /// <summary>
  /// Specifies a Hmmss format.
  /// </summary>
  msoDateTimeHmmss = 11,
  /// <summary>
  /// Specifies a hmmAMPM format. public enum class MsoDateTimeFormat ﾉ Expand table msoDateTimehmmssAMPM13
  /// Specifies a hmmssAMPM format.
  /// </summary>
  msoDateTimehmmAMPM = 12,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  msoDateTimehmmssAMPM = 13,
  /// <summary>
  /// Specifies that the Office application will determine the format.
  /// </summary>
  msoDateTimeFigureOut = 14
}
