
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeFontScheme` interface.
/// </summary>
/// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme?view=office-pia"/>
public interface IThemeFontScheme: IInteropObject
{
  /// <summary>
  /// Gets the `MinorFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.minorfont?view=office-pia"/>
  public IThemeFonts MinorFont { get; }
  /// <summary>
  /// Gets the `MajorFont` property.
  /// </summary>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.majorfont?view=office-pia"/>
  public IThemeFonts MajorFont { get; }


  #region methods

/// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.load?view=office-pia"/>
  public void Load(string fileName);
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.save?view=office-pia"/>
  public void Save(string fileName);

  #endregion methods
}

