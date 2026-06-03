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
  /// <param name="effectType">The `EffectType` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <returns>The inserted picture effect.</returns>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.insert?view=office-pia"/>
  public PictureEffect Insert(PictureEffectType effectType, int position) { throw new NotImplementedException(); }
  /// <summary>
  /// Deletes a picture effect from the collection.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffects.delete?view=office-pia"/>
  public void Delete(int index) { throw new NotImplementedException(); }

  #endregion methods
}

