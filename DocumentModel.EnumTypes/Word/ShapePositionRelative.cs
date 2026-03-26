namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies whether the LeftRelative or TopRelative property for a Shape or ShapeRange is valid.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapepositionrelative?view=office-pia` for Office interop details.
/// </remarks>
public enum ShapePositionRelative
{
  /// <summary>
  /// Specifies whether the LeftRelative or TopRelative property for a Shape or ShapeRange is valid.
  /// </summary>
  None = -999999
}
