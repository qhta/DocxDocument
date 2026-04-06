
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebComponentProperties` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties?view=office-pia"/>
public partial interface IWebComponentProperties: IModelObject
{
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.shape?view=office-pia"/>
  public object Shape { get; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.url?view=office-pia"/>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.html?view=office-pia"/>
  public string HTML { get; set; }
  /// <summary>
  /// Gets or sets the `PreviewGraphic` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.previewgraphic?view=office-pia"/>
  public string PreviewGraphic { get; set; }
  /// <summary>
  /// Gets or sets the `PreviewHTML` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.previewhtml?view=office-pia"/>
  public string PreviewHTML { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.height?view=office-pia"/>
  public int Height { get; set; }
  /// <summary>
  /// Gets or sets the `Tag` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentproperties.tag?view=office-pia"/>
  public string Tag { get; set; }
}

