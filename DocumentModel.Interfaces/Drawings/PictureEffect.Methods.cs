using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents the `PictureEffect` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureEffect: IModelObject
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.delete?view=office-pia"/>
  public void Delete();
}

