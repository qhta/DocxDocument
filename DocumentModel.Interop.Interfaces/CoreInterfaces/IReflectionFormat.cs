
namespace DocumentModel.Interop.Core;	
/// <summary>
/// Represents the reflection effect in Office graphics.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat?view=office-pia"/>
public interface IReflectionFormat: IInteropObject
{
  /// <summary>
  /// Gets or sets the reflection preset type.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.type?view=office-pia"/>
  public ReflectionType Type { get; set; }
  /// <summary>
  /// Gets or sets the transparency of the reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.transparency?view=office-pia"/>
  public float Transparency { get; set; }
  /// <summary>
  /// Gets or sets the size of the reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.size?view=office-pia"/>
  public float Size { get; set; }
  /// <summary>
  /// Gets or sets the distance offset of the reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.offset?view=office-pia"/>
  public float Offset { get; set; }
  /// <summary>
  /// Gets or sets the blur amount applied to the reflection.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.reflectionformat.blur?view=office-pia"/>
  public float Blur { get; set; }
}	
