namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the relative position of the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdshapeposition?view=office-pia` for Office interop details.
/// </remarks>
public enum ShapePosition
{
  /// <summary>
  /// At the top.
  /// </summary>
  Top = -999999,
  /// <summary>
  /// On the left.
  /// </summary>
  Left = -999998,
  /// <summary>
  /// At the bottom.
  /// </summary>
  Bottom = -999997,
  /// <summary>
  /// On the right.
  /// </summary>
  Right = -999996,
  /// <summary>
  /// In the center.
  /// </summary>
  Center = -999995,
  /// <summary>
  /// Inside the selected range.
  /// </summary>
  Inside = -999994,
  /// <summary>
  /// Outside the selected range.
  /// </summary>
  Outside = -999993
}
