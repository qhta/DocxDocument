namespace DocumentModel.Themes;

/// <summary>
/// Represents one of the three language fonts contained in the ThemeFonts collection
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msofontlanguageindex?view=office-pia` for Office interop details.
/// </remarks>
public enum FontLanguageIndex
{
  /// <summary>
  /// Represents the Latin font face.
  /// </summary>
  Latin = 1,
  /// <summary>
  /// Represents the font face for Complex Script languages. The Complex Script language collection supports Arabic,
  /// Georgian, Hebrew, Indian, Thai and Vietnamese alphabets.
  /// </summary>
  ComplexScript,
  /// <summary>
  /// Represents the East Asian font face. East Asian Languages include Simplified Chinese, Traditional Chinese,
  /// Japanese, and Korean.
  /// </summary>
  EastAsian
}
