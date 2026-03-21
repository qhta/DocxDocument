namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents horizontal line formatting.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat?view=word-pia"/>
public interface HorizontalLineFormat : InteropObject
{
  /// <summary>
  /// The percent width.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.percentwidth?view=word-pia"/>
  public float PercentWidth { get; set; }
  /// <summary>
  /// The no shade.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.noshade?view=word-pia"/>
  public bool NoShade { get; set; }
  /// <summary>
  /// The alignment.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.alignment?view=word-pia"/>
  public WdHorizontalLineAlignment Alignment { get; set; }
  /// <summary>
  /// The width type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.widthtype?view=word-pia"/>
  public WdHorizontalLineWidthType WidthType { get; set; }

}
