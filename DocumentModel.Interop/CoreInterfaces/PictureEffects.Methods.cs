using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PictureEffects` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureEffects
{
  /// <summary>
  /// Invokes `Insert`.
  /// </summary>
  /// <param name="EffectType">The `EffectType` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The result of the operation.</returns>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.insert?view=office-pia
  /// </remarks>
  public PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.delete?view=office-pia
  /// </remarks>
  public void Delete(int Index);
}
