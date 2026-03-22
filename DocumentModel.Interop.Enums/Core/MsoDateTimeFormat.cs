namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
public enum MsoDateTimeFormat
{
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  FormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format. msoDateTimeddddMMMMddyyyy2 Specifies a ddddMMMMddyyyy format.
  /// </summary>
  Mdyy = 1,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  ddddMMMMddyyyy = 2,
  /// <summary>
  /// Specifies MMMMyyyy format.
  /// </summary>
  dMMMMyyyy = 3,
  /// <summary>
  /// Specifies a MMMMdyyyy format.
  /// </summary>
  MMMMdyyyy = 4,
  /// <summary>
  /// Specifies MMMyy format.
  /// </summary>
  dMMMyy = 5,
  /// <summary>
  /// Specifies a MMMMyy format.
  /// </summary>
  MMMMyy = 6,
  /// <summary>
  /// Specifies a MMyy format. msoDateTimeMMddyyHmm8 Specifies a MMddyyHmm format. msoDateTimeMMddyyhmmAMPM9
  /// Specifies a MMddyyhmmAMPM format.
  /// </summary>
  MMyy = 7,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  MMddyyHmm = 8,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  MMddyyhmmAMPM = 9,
  /// <summary>
  /// Specifies Hmm format.
  /// </summary>
  Hmm = 10,
  /// <summary>
  /// Specifies a Hmmss format.
  /// </summary>
  Hmmss = 11,
  /// <summary>
  /// Specifies a hmmAMPM format. public enum class MsoDateTimeFormat ﾉ Expand table msoDateTimehmmssAMPM13
  /// Specifies a hmmssAMPM format.
  /// </summary>
  hmmAMPM = 12,
  /// <summary>
  /// Specifies the format of a date/time data type.
  /// </summary>
  hmmssAMPM = 13,
  /// <summary>
  /// Specifies that the Office application will determine the format.
  /// </summary>
  FigureOut = 14
}
