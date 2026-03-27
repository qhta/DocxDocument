
namespace DocumentModel.Drawings;

/// <summary>
/// Represents the `ThemeFontScheme` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme?view=office-pia"/>
public partial interface ThemeFontScheme: InteropObject
{
  /// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.load?view=office-pia"/>
  public void Load(string FileName);
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="FileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.save?view=office-pia"/>
  public void Save(string FileName);
}

