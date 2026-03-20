
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the reflection effect in Office graphics.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat?view=office-pia
/// </remarks>
public partial interface ReflectionFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the reflection preset type.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.type?view=office-pia
  /// </remarks>
  public MsoReflectionType Type { get; set; }
  /// <summary>
  /// Gets or sets the transparency of the reflection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the size of the reflection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.size?view=office-pia
  /// </remarks>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the distance offset of the reflection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.offset?view=office-pia
  /// </remarks>
  public float Offset { get; set; }
  /// <summary>
  /// Gets or sets the blur amount applied to the reflection.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.blur?view=office-pia
  /// </remarks>
  public float Blur { get; set; }
}
