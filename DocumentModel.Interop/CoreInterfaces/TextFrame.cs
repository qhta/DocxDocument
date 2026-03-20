
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextFrame` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe?view=office-pia
/// </remarks>
public partial interface TextFrame: InteropObject
{
  /// <summary>
  /// Gets or sets the `MarginBottom` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe.marginbottom?view=office-pia
  /// </remarks>
  public float MarginBottom { get; set; }
  /// <summary>
  /// Gets or sets the `MarginLeft` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe.marginleft?view=office-pia
  /// </remarks>
  public float MarginLeft { get; set; }
  /// <summary>
  /// Gets or sets the `MarginRight` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe.marginright?view=office-pia
  /// </remarks>
  public float MarginRight { get; set; }
  /// <summary>
  /// Gets or sets the `MarginTop` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe.margintop?view=office-pia
  /// </remarks>
  public float MarginTop { get; set; }
  /// <summary>
  /// Gets or sets the `Orientation` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.textframe.orientation?view=office-pia
  /// </remarks>
  public MsoTextOrientation Orientation { get; set; }
}
