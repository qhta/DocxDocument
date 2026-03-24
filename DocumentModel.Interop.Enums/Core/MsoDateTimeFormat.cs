namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a date/time data type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msodatetimeformat?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoDateTimeFormat
{
  /// <summary>
  /// Specifies a mixed format.
  /// </summary>
  FormatMixed = -2,
  /// <summary>
  /// Specifies a Mdyy format.
  /// </summary>
  Mdyy = 1,
  /// <summary>
  /// Specifies a ddddMMMMddyyyy format.
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
  /// Specifies a MMyy format.
  /// </summary>
  MMyy = 7,
  /// <summary>
  /// Specifies a MMddyyHmm format.
  /// </summary>
  MMddyyHmm = 8,
  /// <summary>
  /// Specifies a MMddyyhmmAMPM format.
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
  /// Specifies a hmmAMPM format. public enum class MsoDateTimeFormat
  /// </summary>
  hmmAMPM = 12,
  /// <summary>
  /// Specifies a hmmssAMPM format.
  /// </summary>
  hmmssAMPM = 13,
  /// <summary>
  /// Specifies that the Office application will determine the format.
  /// </summary>
  FigureOut = 14
}
