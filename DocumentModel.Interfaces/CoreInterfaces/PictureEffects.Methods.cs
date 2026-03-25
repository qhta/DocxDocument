using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of picture effects.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects?view=office-pia"/>
public partial interface PictureEffects
{
  /// <summary>
  /// Inserts a picture effect in the effects chain.
  /// </summary>
  /// <param name="EffectType">The `EffectType` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The inserted picture effect.</returns>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.insert?view=office-pia"/>
  public PictureEffect Insert(MsoPictureEffectType EffectType, int Position);
  /// <summary>
  /// Deletes a picture effect from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.delete?view=office-pia"/>
  public void Delete(int Index);
}

