namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the type of shadowing effect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshadowstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum ShadowStyle
{
  /// <summary>
  /// Specifies a combination of inner and outer shadow effects.
  /// </summary>
  /// <summary>
  /// Specifies the inner shadow effect.
  /// </summary>
  InnerShadow = 1,
  /// <summary>
  /// Specifies the outer shadow effect.
  /// </summary>
  OuterShadow = 2
}
