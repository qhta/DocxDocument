
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `ThemeFontScheme` class.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme?view=office-pia"/>
public partial class ThemeFontScheme: InteropObject
{
  /// <summary>
  /// Gets the `MinorFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.minorfont?view=office-pia"/>
  public ThemeFonts MinorFont { get; }
  /// <summary>
  /// Gets the `MajorFont` property.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.majorfont?view=office-pia"/>
  public ThemeFonts MajorFont { get; }


  #region methods

/// <summary>
  /// Invokes `Load`.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.load?view=office-pia"/>
  public void Load(string fileName) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Save`.
  /// </summary>
  /// <param name="fileName">The `FileName` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.themefontscheme.save?view=office-pia"/>
  public void Save(string fileName) { throw new NotImplementedException(); }

  #endregion methods
}

