
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponent` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent?view=office-pia
/// </remarks>
public partial interface WebComponent
{
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.shape?view=office-pia
  /// </remarks>
  public object Shape { get; }
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.url?view=office-pia
  /// </remarks>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.html?view=office-pia
  /// </remarks>
  public string HTML { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.width?view=office-pia
  /// </remarks>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.height?view=office-pia
  /// </remarks>
  public int Height { get; set; }
}
