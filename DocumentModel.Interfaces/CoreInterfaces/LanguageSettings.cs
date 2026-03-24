
namespace DocumentModel.Interfaces;

/// <summary>
/// Represents language settings used by the Office application.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.languagesettings?view=office-pia"/>
public partial interface LanguageSettings: InteropObject
{
  /// <summary>
  /// Gets the `LanguageID` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.languagesettings.languageid?view=office-pia"/>
  public int LanguageID { get; }
  /// <summary>
  /// Gets the `LanguagePreferredForEditing` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.languagesettings.languagepreferredforediting?view=office-pia"/>
  public bool LanguagePreferredForEditing { get; }
}

