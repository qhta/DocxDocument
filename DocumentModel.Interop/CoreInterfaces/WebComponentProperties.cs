
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponentProperties` interface.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties?view=office-pia
/// </remarks>
public partial interface WebComponentProperties
{
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.shape?view=office-pia
  /// </remarks>
  public object Shape { get; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.name?view=office-pia
  /// </remarks>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.url?view=office-pia
  /// </remarks>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.html?view=office-pia
  /// </remarks>
  public string HTML { get; set; }
  /// <summary>
  /// Gets or sets the `PreviewGraphic` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.previewgraphic?view=office-pia
  /// </remarks>
  public string PreviewGraphic { get; set; }
  /// <summary>
  /// Gets or sets the `PreviewHTML` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.previewhtml?view=office-pia
  /// </remarks>
  public string PreviewHTML { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.width?view=office-pia
  /// </remarks>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.height?view=office-pia
  /// </remarks>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.tag?view=office-pia
  /// </remarks>
  public string Tag { get; set; }
}
