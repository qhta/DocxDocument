namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the interior of an object.
/// </summary>
/// <remarks>
/// Microsoft Learn API reference.
/// </remarks>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior?view=word-pia"/>
public interface Interior : InteropObject
{
  /// <summary>
  /// The color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.color?view=word-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// The color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.colorindex?view=word-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// The invert if negative.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.invertifnegative?view=word-pia"/>
  public object InvertIfNegative { get; set; }
  /// <summary>
  /// The pattern.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.pattern?view=word-pia"/>
  public object Pattern { get; set; }
  /// <summary>
  /// The pattern color.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.patterncolor?view=word-pia"/>
  public object PatternColor { get; set; }
  /// <summary>
  /// The pattern color index.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn API reference.
  /// </remarks>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.patterncolorindex?view=word-pia"/>
  public object PatternColorIndex { get; set; }

}
