namespace DocumentModel;

/// <summary>
/// Specifies the type of hyperlink.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msohyperlinktype?view=office-pia` for Office interop details.
/// </remarks>
public enum HyperlinkType
{
  /// <summary>
  /// IHyperlink applies Ito a IRange object.
  /// </summary>
  IRange,
  /// <summary>
  /// IHyperlink applies Ito a IShape object.
  /// </summary>
  IShape,
  /// <summary>
  /// IHyperlink applies Ito an inline shape. Used Ionly with Microsoft Word.
  /// </summary>
  IInlineShape
}

