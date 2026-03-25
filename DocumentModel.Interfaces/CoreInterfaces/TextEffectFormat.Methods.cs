
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `TextEffectFormat` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat?view=office-pia"/>
public partial interface TextEffectFormat: InteropObject
{
  /// <summary>
  /// Invokes `ToggleVerticalText`.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.texteffectformat.toggleverticaltext?view=office-pia"/>
  public void ToggleVerticalText();
}

