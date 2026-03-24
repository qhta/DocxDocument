namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the wrap type for the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptype?view=office-pia` for Office interop details.
/// </remarks>
public enum WdWrapType
{
  /// <summary>
  /// Wraps text around the shape. Line continuation is on the opposite side of the shape.
  /// </summary>
  Square = 0,
  /// <summary>
  /// Tight.
  /// </summary>
  Tight = 1,
  /// <summary>
  /// Specifies the wrap type for the specified shape.
  /// </summary>
  Through = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  None = 3,
  /// <summary>
  /// Places shape in front of text.
  /// </summary>
  Front = 3,
  /// <summary>
  /// Specifies the wrap type for the specified shape.
  /// </summary>
  TopBottom = 4,
  /// <summary>
  /// Places shape behind text.
  /// </summary>
  Behind = 5,
  /// <summary>
  /// In line with text.
  /// </summary>
  Inline = 7
}
