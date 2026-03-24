namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of hyperlink.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohyperlinktype?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoHyperlinkType
{
  /// <summary>
  /// Hyperlink
  /// </summary>
  Range,
  /// <summary>
  /// Hyperlink
  /// </summary>
  Shape,
  /// <summary>
  /// Specifies the type of hyperlink.
  /// </summary>
  InlineShape
}
