
namespace DocumentModel.Drawings;

/// <summary>
/// Represents one gradient stop.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop?view=office-pia"/>
public partial interface IGradientStop: IModelObject
{
  /// <summary>
  /// Gets or sets the `Color` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.color?view=office-pia"/>
  public IColorFormat Color { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.position?view=office-pia"/>
  public float Position { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Transparency` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstop.transparency?view=office-pia"/>
  public float Transparency { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

