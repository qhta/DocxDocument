namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the interior of an object.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior?view=word-pia"/>
public interface IInterior : IInteropObject
{
  /// <summary>
  /// Returns or sets the primary color of the object interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.color?view=word-pia"/>
  public object Color { get; set; }
  /// <summary>
  /// Returns or sets the color index of the object interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.colorindex?view=word-pia"/>
  public object ColorIndex { get; set; }
  /// <summary>
  /// Returns or sets whether the interior pattern is inverted for negative values.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.invertifnegative?view=word-pia"/>
  public object InvertIfNegative { get; set; }
  /// <summary>
  /// Returns or sets the fill pattern for the object interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.pattern?view=word-pia"/>
  public object Pattern { get; set; }
  /// <summary>
  /// Returns or sets the pattern color of the object interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.patterncolor?view=word-pia"/>
  public object PatternColor { get; set; }
  /// <summary>
  /// Returns or sets the pattern color index of the object interior.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.interior.patterncolorindex?view=word-pia"/>
  public object PatternColorIndex { get; set; }

}
