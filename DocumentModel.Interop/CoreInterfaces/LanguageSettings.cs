
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents language settings used by the Office application.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.languagesettings?view=office-pia
/// </remarks>
public partial interface LanguageSettings: InteropObject
{
  /// <summary>
  /// Gets the `LanguageID` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.languagesettings.languageid?view=office-pia
  /// </remarks>
  public int LanguageID { get; }
  /// <summary>
  /// Gets the `LanguagePreferredForEditing` property.
  /// </summary>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.languagesettings.languagepreferredforediting?view=office-pia
  /// </remarks>
  public bool LanguagePreferredForEditing { get; }
}
