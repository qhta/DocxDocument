using System.Reflection;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `PictureEffect` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect?view=office-pia` for Office interop details.
/// </remarks>
public partial interface PictureEffect: InteropObject
{
  /// <summary>
  /// Gets or sets the `Type` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.type?view=office-pia
  /// </remarks>
  public MsoPictureEffectType Type { get; }
  /// <summary>
  /// Gets or sets the `Position` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.position?view=office-pia
  /// </remarks>
  public int Position { get; set; }
  /// <summary>
  /// Gets the `EffectParameters` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.effectparameters?view=office-pia
  /// </remarks>
  public EffectParameters EffectParameters { get; }
  /// <summary>
  /// Gets or sets the `Visible` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.pictureeffect.visible?view=office-pia
  /// </remarks>
  public MsoTriState Visible { get; set; }
}
