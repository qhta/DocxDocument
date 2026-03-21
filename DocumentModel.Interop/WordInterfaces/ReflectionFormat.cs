namespace DocumentModel.Interop.Word;

/// <summary>
/// Represents the reflection formatting for a shape or range of shapes.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat?view=word-pia"/>
public interface ReflectionFormat : InteropObject
{
  /// <summary>
  /// Returns or sets the type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.type?view=word-pia"/>
  public Core.MsoReflectionType Type { get; set; }
  /// <summary>
  /// Returns or sets the transparency.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Returns or sets the size.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.size?view=word-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// Returns or sets the offset.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.offset?view=word-pia"/>
  public float Offset { get; set; }
  /// <summary>
  /// Returns or sets the blur.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.blur?view=word-pia"/>
  public float Blur { get; set; }

}
