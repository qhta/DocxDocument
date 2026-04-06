
namespace DocumentModel.Application;

/// <summary>
/// Represents the `WebComponent` interface.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent?view=office-pia"/>
public partial interface IWebComponent: IModelObject
{
  /// <summary>
  /// Invokes `SetPlaceHolderGraphic`.
  /// </summary>
  /// <param name="PlaceHolderGraphic">The `PlaceHolderGraphic` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.setplaceholdergraphic?view=office-pia"/>
  public void SetPlaceHolderGraphic(string PlaceHolderGraphic);
  /// <summary>
  /// Invokes `Commit`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.commit?view=office-pia"/>
  public void Commit();
  /// <summary>
  /// Invokes `Revert`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.revert?view=office-pia"/>
  public void Revert();
}

