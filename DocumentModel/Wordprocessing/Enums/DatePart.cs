namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies, which part of date is presented.
///   Used in element <see cref="RunDate"/>
/// </summary>
[Flags]
public enum DatePart
{
  /// <summary>
  ///   Day is presented
  /// </summary>
  Day = 1,

  /// <summary>
  ///   Month is presented
  /// </summary>
  Month = 2,

  /// <summary>
  ///   Year is presented
  /// </summary>
  Year = 4,

  /// <summary>
  ///   Full date is presented
  /// </summary>
  Full = 7,


}