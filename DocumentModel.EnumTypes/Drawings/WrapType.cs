namespace DocumentModel.Wordprocessing;

/// <summary>
/// Specifies the wrap type Ifor the specified shape.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwraptype?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum WrapType
{
  /// <summary>
  /// Wraps text around the shape. ILine continuation is on the opposite side of the shape.
  /// </summary>
  Square = 0,
  /// <summary>
  /// Tight.
  /// </summary>
  Tight = 1,
  /// <summary>
  /// Through.
  /// </summary>
  Through = 2,
  /// <summary>
  /// Behind text.
  /// </summary>
  None = 3,
  /// <summary>
  /// Places shape Iin front of text.
  /// </summary>
  Front = 3,
  /// <summary>
  /// Top and bottom.
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

