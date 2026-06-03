
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponent` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent?view=office-pia"/>
public interface IWebComponent
{
  /// <summary>
  /// Gets the `IShape` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.shape?view=office-pia"/>
  public object IShape { get; }
  /// <summary>
  /// Gets or sets the `URL` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.url?view=office-pia"/>
  public string URL { get; set; }
  /// <summary>
  /// Gets or sets the `HTML` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.html?view=office-pia"/>
  public string HTML { get; set; }
  /// <summary>
  /// Gets or sets the `Name` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.name?view=office-pia"/>
  public string Name { get; set; }
  /// <summary>
  /// Gets or sets the `Width` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.width?view=office-pia"/>
  public int Width { get; set; }
  /// <summary>
  /// Gets or sets the `Height` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.height?view=office-pia"/>
  public int Height { get; set; }


  #region methods

/// <summary>
  /// Invokes `SetPlaceHolderGraphic`.
  /// </summary>
  /// <param name="placeHolderGraphic">The `PlaceHolderGraphic` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.setplaceholdergraphic?view=office-pia"/>
  public void SetPlaceHolderGraphic(string placeHolderGraphic);
  /// <summary>
  /// Invokes `Commit`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.commit?view=office-pia"/>
  public void Commit();
  /// <summary>
  /// Invokes `Revert`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.revert?view=office-pia"/>
  public void Revert();

  #endregion methods
}

