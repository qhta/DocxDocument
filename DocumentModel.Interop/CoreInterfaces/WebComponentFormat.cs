
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface WebComponentFormat
{
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.url?view=office-pia
  /// </remarks>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.html?view=office-pia
  /// </remarks>
  public string HTML { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.width?view=office-pia
  /// </remarks>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.height?view=office-pia
  /// </remarks>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `PreviewGraphic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.previewgraphic?view=office-pia
  /// </remarks>
  public string PreviewGraphic { get; set; }
}
