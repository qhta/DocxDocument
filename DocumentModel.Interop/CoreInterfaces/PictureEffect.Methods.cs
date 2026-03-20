using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PictureEffect` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureEffect
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.delete?view=office-pia
  /// </remarks>
  public void Delete();
}
