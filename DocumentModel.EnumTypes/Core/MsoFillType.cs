namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies a shape's fill type.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofilltype?view=office-pia` for Office interop details.
/// </remarks>
public enum FillType
{
  /// <summary>
  /// Mixed fill.
  /// </summary>
  /// <summary>
  /// Solid fill.
  /// </summary>
  Solid = 1,
  /// <summary>
  /// Patterned fill.
  /// </summary>
  Patterned = 2,
  /// <summary>
  /// Gradient fill.
  /// </summary>
  Gradient = 3,
  /// <summary>
  /// Textured fill.
  /// </summary>
  Textured = 4,
  /// <summary>
  /// Fill is the same as the background.
  /// </summary>
  Background = 5,
  /// <summary>
  /// Picture fill.
  /// </summary>
  Picture = 6
}
