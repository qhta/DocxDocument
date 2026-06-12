
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebComponent` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent?view=office-pia"/>
public partial interface IWebComponent: IModelObject
{
  /// <summary>
  /// Gets the `Shape` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.shape?view=office-pia"/>
  public object Shape { get; }
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.url?view=office-pia"/>
  public string URL { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.html?view=office-pia"/>
  public string HTML { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.name?view=office-pia"/>
  public string Name { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.width?view=office-pia"/>
  public int Width { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.height?view=office-pia"/>
  public int Height { [DebuggerStepThrough] get; [DebuggerStepThrough] set; }
}

