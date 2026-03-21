
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThreeDFormat` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat?view=office-pia"/>
public partial interface ThreeDFormat
{
  /// <summary>
  /// Invokes `IncrementRotationX`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationx?view=office-pia"/>
  public void IncrementRotationX(float Increment);
  /// <summary>
  /// Invokes `IncrementRotationY`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationy?view=office-pia"/>
  public void IncrementRotationY(float Increment);
  /// <summary>
  /// Invokes `ResetRotation`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.resetrotation?view=office-pia"/>
  public void ResetRotation();
  /// <summary>
  /// Invokes `SetThreeDFormat`.
  /// </summary>
  /// <param name="PresetThreeDFormat">The `PresetThreeDFormat` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.setthreedformat?view=office-pia"/>
  public void SetThreeDFormat(MsoPresetThreeDFormat PresetThreeDFormat);
  /// <summary>
  /// Invokes `SetExtrusionDirection`.
  /// </summary>
  /// <param name="PresetExtrusionDirection">The `PresetExtrusionDirection` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.setextrusiondirection?view=office-pia"/>
  public void SetExtrusionDirection(MsoPresetExtrusionDirection PresetExtrusionDirection);
  /// <summary>
  /// Invokes `SetPresetCamera`.
  /// </summary>
  /// <param name="PresetCamera">The `PresetCamera` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.setpresetcamera?view=office-pia"/>
  public void SetPresetCamera(MsoPresetCamera PresetCamera);
  /// <summary>
  /// Invokes `IncrementRotationZ`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationz?view=office-pia"/>
  public void IncrementRotationZ(float Increment);
  /// <summary>
  /// Invokes `IncrementRotationHorizontal`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationhorizontal?view=office-pia"/>
  public void IncrementRotationHorizontal(float Increment);
  /// <summary>
  /// Invokes `IncrementRotationVertical`.
  /// </summary>
  /// <param name="Increment">The `Increment` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.threedformat.incrementrotationvertical?view=office-pia"/>
  public void IncrementRotationVertical(float Increment);
}

