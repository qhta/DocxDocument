namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the relative position of the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapeposition?view=office-pia` for Office interop details.
/// </remarks>
public enum WdShapePosition
{
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Top = -999999,
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Left = -999998,
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Bottom = -999997,
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Right = -999996,
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Center = -999995,
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Inside = -999994,
  /// <summary>
  /// Specifies the relative position of the specified shape.
  /// </summary>
  Outside = -999993
}
