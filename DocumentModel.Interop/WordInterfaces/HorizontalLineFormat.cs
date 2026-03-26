namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents horizontal line formatting.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat?view=word-pia"/>
public interface HorizontalLineFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the width of the horizontal line as a percentage of the window width.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.percentwidth?view=word-pia"/>
  public float PercentWidth { get; set; }
  /// <summary>
  /// Returns or sets whether the horizontal line is displayed without three-dimensional shading.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.noshade?view=word-pia"/>
  public bool NoShade { get; set; }
  /// <summary>
  /// Returns or sets the alignment for the horizontal line.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.alignment?view=word-pia"/>
  public HorizontalLineAlignment Alignment { get; set; }
  /// <summary>
  /// Returns or sets how the width of the horizontal line is measured.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.horizontallineformat.widthtype?view=word-pia"/>
  public HorizontalLineWidthType WidthType { get; set; }

}
