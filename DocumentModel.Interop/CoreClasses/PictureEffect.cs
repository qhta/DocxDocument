using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a picture effect.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect?view=office-pia"/>
public partial class PictureEffect: InteropObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.type?view=office-pia"/>
  public PictureEffectType Type { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.position?view=office-pia"/>
  public int Position { get; set; }
  /// <summary>
  /// Gets the `EffectParameters` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.effectparameters?view=office-pia"/>
  public EffectParameters EffectParameters { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.visible?view=office-pia"/>
  public TriState Visible { get; set; }


  #region methods

/// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }

  #endregion methods
}

