namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a shape's fill type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilltype?view=office-pia` for Office interop details.
/// </remarks>
[OfficeInteropEnumType("MsoFillType")]
public enum FillType
{
  /// <summary>
  /// Mixed fill.
  /// </summary>
  [OfficeInteropEnumValue("msoFillMixed")]
  Mixed = -2,
  /// <summary>
  /// Solid fill.
  /// </summary>
  [OfficeInteropEnumValue("msoFillSolid")]
  Solid = 1,
  /// <summary>
  /// Patterned fill.
  /// </summary>
  [OfficeInteropEnumValue("msoFillPatterned")]
  Patterned = 2,
  /// <summary>
  /// Gradient fill.
  /// </summary>
  [OfficeInteropEnumValue("msoFillGradient")]
  Gradient = 3,
  /// <summary>
  /// Textured fill.
  /// </summary>
  [OfficeInteropEnumValue("msoFillTextured")]
  Textured = 4,
  /// <summary>
  /// Fill is the same as the background.
  /// </summary>
  [OfficeInteropEnumValue("msoFillBackground")]
  Background = 5,
  /// <summary>
  /// Picture fill.
  /// </summary>
  [OfficeInteropEnumValue("msoFillPicture")]
  Picture = 6
}
