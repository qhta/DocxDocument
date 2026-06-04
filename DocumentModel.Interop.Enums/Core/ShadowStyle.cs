namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of shadowing effect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshadowstyle?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Core.MsoShadowStyle")]
public enum ShadowStyle
{
  /// <summary>
  /// Specifies a combination of inner and outer shadow effects.
  /// </summary>
  [InteropEnumValue("msoShadowStyleMixed")]
  Mixed = -2,
  /// <summary>
  /// Specifies the inner shadow effect.
  /// </summary>
  [InteropEnumValue("msoShadowStyleInnerShadow")]
  InnerShadow = 1,
  /// <summary>
  /// Specifies the outer shadow effect.
  /// </summary>
  [InteropEnumValue("msoShadowStyleOuterShadow")]
  OuterShadow = 2
}
