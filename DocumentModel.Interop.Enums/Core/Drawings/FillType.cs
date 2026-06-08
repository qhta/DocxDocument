namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a shape's fill type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilltype?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoFillType")]
public enum FillType
{
  /// <summary>
  /// Mixed fill.
  /// </summary>
  [InteropEnumValue("msoFillMixed")]
  Mixed = -2,
  /// <summary>
  /// Solid fill.
  /// </summary>
  [InteropEnumValue("msoFillSolid")]
  Solid = 1,
  /// <summary>
  /// Patterned fill.
  /// </summary>
  [InteropEnumValue("msoFillPatterned")]
  Patterned = 2,
  /// <summary>
  /// Gradient fill.
  /// </summary>
  [InteropEnumValue("msoFillGradient")]
  Gradient = 3,
  /// <summary>
  /// Textured fill.
  /// </summary>
  [InteropEnumValue("msoFillTextured")]
  Textured = 4,
  /// <summary>
  /// Fill is the same as the background.
  /// </summary>
  [InteropEnumValue("msoFillBackground")]
  Background = 5,
  /// <summary>
  /// Picture fill.
  /// </summary>
  [InteropEnumValue("msoFillPicture")]
  Picture = 6
}
