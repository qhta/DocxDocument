using System.Reflection;

namespace DocumentModel.Drawings;

/// <summary>
/// Represents a picture effect.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect?view=office-pia"/>
public partial interface PictureEffect: IModelObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.type?view=office-pia"/>
  public PictureEffectType Type { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.position?view=office-pia"/>
  public int Position { get; set; }
  /// <summary>
  /// Gets the `EffectParameters` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.effectparameters?view=office-pia"/>
  public EffectParameters EffectParameters { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.visible?view=office-pia"/>
  public TriState Visible { get; set; }
}

