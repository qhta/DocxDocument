using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents the `PictureEffect` interface.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect?view=office-pia` for Office interop details.
/// </remarks>
public partial interface IPictureEffect: IModelObject
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.delete?view=office-pia"/>
  public void Delete();
}

