namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the type of join where two lines connect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msolinejoinstyle?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum LineJoinStyle
{
  /// <summary>
  /// Specifies a mixture of join types.
  /// </summary>
  /// <summary>
  /// Specifies a rounded join.
  /// </summary>
  Round = 1,
  /// <summary>
  /// Specifies a beveled join.
  /// </summary>
  Bevel = 2,
  /// <summary>
  /// Specifies a mitered join.
  /// </summary>
  Miter = 3
}

