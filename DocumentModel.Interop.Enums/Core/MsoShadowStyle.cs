namespace DocumentModel.Interop.Core;

/// <summary>
/// Specifies the type of shadowing effect.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msoshadowstyle?view=office-pia` for Office interop details.
/// </remarks>
public enum MsoShadowStyle
{
  /// <summary>
  /// Specifies the type of shadowing effect.
  /// </summary>
  Mixed = -2,
  /// <summary>
  /// Specifies the type of shadowing effect.
  /// </summary>
  InnerShadow = 1,
  /// <summary>
  /// Specifies the type of shadowing effect.
  /// </summary>
  OuterShadow = 2
}
