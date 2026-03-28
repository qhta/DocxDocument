namespace DocumentModel.Drawings;

/// <summary>
/// Specifies which part of the shape retains its position when the shape is scaled.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoscalefrom?view=office-pia` for Office interop details.
/// </remarks>
public enum ScaleFrom
{
  /// <summary>
  /// Shape's top left corner retains its position.
  /// </summary>
  TopLeft,
  /// <summary>
  /// Shape's midpoint retains its position.
  /// </summary>
  Middle,
  /// <summary>
  /// Shape's bottom right corner retains its position.
  /// </summary>
  BottomRight
}
