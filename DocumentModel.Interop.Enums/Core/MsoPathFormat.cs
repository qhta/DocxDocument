namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the format of a file or folder path.
/// </summary>
public enum MsoPathFormat
{
  /// <summary>
  /// Specifies the format of a file or folder path.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Represents no format.
  /// </summary>
  None = 0,
  /// <summary>
  /// Represents the Type1 format.
  /// </summary>
  Type1 = 1,
  /// <summary>
  /// Represents the Type2 format.
  /// </summary>
  Type2 = 2,
  /// <summary>
  /// Represents the Type3 format.
  /// </summary>
  Type3 = 3,
  /// <summary>
  /// Represents the Type4 format.
  /// </summary>
  Type4 = 4
}
