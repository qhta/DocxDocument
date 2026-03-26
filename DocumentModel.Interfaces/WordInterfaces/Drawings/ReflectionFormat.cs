namespace DocumentModel.Wordprocessing;

/// <summary>
/// Represents the reflection formatting for a shape or range of shapes.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat?view=word-pia"/>
public interface ReflectionFormat : InteropObject
{
  /// <summary>
  /// Returns or sets an LightRigType constant that represents the type and direction of the lighting for a shape
  /// reflection. Read/write.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.type?view=word-pia"/>
  public Core.ReflectionType Type { get; set; }
  /// <summary>
  /// Gets or sets the degree of transparency for the reflection effect as a value between 0.0 (opaque) and 1.0
  /// (clear).
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.transparency?view=word-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the size of the reflection as a percentage of the reflected shape from 0 to 100.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.size?view=word-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the amount of separation, in points, of the reflected image from the shape.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.offset?view=word-pia"/>
  public float Offset { get; set; }
  /// <summary>
  /// Gets or sets a value that specifies the degree of blur effect applied to the specified object.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.reflectionformat.blur?view=word-pia"/>
  public float Blur { get; set; }

}
