
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ReflectionFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface ReflectionFormat: InteropObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.type?view=office-pia
  /// </remarks>
  public MsoReflectionType Type { get; set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.transparency?view=office-pia
  /// </remarks>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the `Size` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.size?view=office-pia
  /// </remarks>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the `Offset` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.offset?view=office-pia
  /// </remarks>
  public float Offset { get; set; }
  /// <summary>
  /// Gets or sets the `Blur` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.blur?view=office-pia
  /// </remarks>
  public float Blur { get; set; }
}
