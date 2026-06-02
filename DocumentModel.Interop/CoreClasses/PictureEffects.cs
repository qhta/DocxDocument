using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of picture effects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects?view=office-pia"/>
public partial class PictureEffects: InteropCollection<PictureEffect>
{


  #region methods

/// <summary>
  /// Inserts a picture effect in the effects chain.
  /// </summary>
  /// <param name="EffectType">The `EffectType` parameter.</param>
  /// <param name="Position">The `Position` parameter.</param>
  /// <returns>The inserted picture effect.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.insert?view=office-pia"/>
  public PictureEffect Insert(PictureEffectType EffectType, int Position) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes a picture effect from the collection.
  /// </summary>
  /// <param name="Index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.delete?view=office-pia"/>
  public void Delete(int Index) { throw new NotImplementedException(); }

  #endregion methods
}

