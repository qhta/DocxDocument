namespace DocumentMode.Office;

/// <summary>
/// Specifies the type of hyperlink.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohyperlinktype?view=office-pia` for Office interop details.
/// </remarks>
public enum HyperlinkType
{
  /// <summary>
  /// Hyperlink applies to a Range object.
  /// </summary>
  Range,
  /// <summary>
  /// Hyperlink applies to a Shape object.
  /// </summary>
  Shape,
  /// <summary>
  /// Hyperlink applies to an inline shape. Used only with Microsoft Word.
  /// </summary>
  InlineShape
}
