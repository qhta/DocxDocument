namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the format of a file or folder path.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msopathformat?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum PathFormat
{
  /// <summary>
  /// Represents a mixed format.
  /// </summary>
  /// <summary>
  /// Represents no format.
  /// </summary>
  None = 0,
  /// <summary>
  /// Represents the Type1 format.
  /// </summary>
  PathType1 = 1,
  /// <summary>
  /// Represents the Type2 format.
  /// </summary>
  PathType2 = 2,
  /// <summary>
  /// Represents the Type3 format.
  /// </summary>
  PathType3 = 3,
  /// <summary>
  /// Represents the Type4 format.
  /// </summary>
  Type4 = 4
}

