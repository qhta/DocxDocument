
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebComponentFormat` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat?view=office-pia"/>
public partial interface IWebComponentFormat: IModelObject
{
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.url?view=office-pia"/>
  public string URL { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.html?view=office-pia"/>
  public string HTML { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.name?view=office-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.width?view=office-pia"/>
  public int Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.height?view=office-pia"/>
  public int Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `PreviewGraphic` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponentformat.previewgraphic?view=office-pia"/>
  public string PreviewGraphic { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

