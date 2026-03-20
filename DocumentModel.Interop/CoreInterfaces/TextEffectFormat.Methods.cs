
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextEffectFormat` interface.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat?view=office-pia` for Office interop details.
/// </remarks>
public partial interface TextEffectFormat
{
  /// <summary>
  /// Invokes `ToggleVerticalText`.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.toggleverticaltext?view=office-pia
  /// </remarks>
  public void ToggleVerticalText();
}
