
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `WebComponent` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent?view=office-pia` for Office interop details.
/// </remarks>
public partial interface WebComponent
{
  /// <summary>
  /// Invokes `SetPlaceHolderGraphic`.
  /// </summary>
  /// <param name="PlaceHolderGraphic">The `PlaceHolderGraphic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.setplaceholdergraphic?view=office-pia
  /// </remarks>
  public void SetPlaceHolderGraphic(string PlaceHolderGraphic);
  /// <summary>
  /// Invokes `Commit`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.commit?view=office-pia
  /// </remarks>
  public void Commit();
  /// <summary>
  /// Invokes `Revert`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.webcomponent.revert?view=office-pia
  /// </remarks>
  public void Revert();
}
