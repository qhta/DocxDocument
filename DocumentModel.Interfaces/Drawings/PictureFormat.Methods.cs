
namespace DocumentModel.Drawings;

/// <summary>
/// Contains properties for formatting pictures and OLE objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat?view=office-pia"/>
public partial interface IPictureFormat: IModelObject
{
  /// <summary>
  /// Changes the picture brightness by the specified amount.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.incrementbrightness?view=office-pia"/>
  public void IncrementBrightness(float Increment);
  /// <summary>
  /// Changes the picture contrast by the specified amount.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureformat.incrementcontrast?view=office-pia"/>
  public void IncrementContrast(float Increment);
}

