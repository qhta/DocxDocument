namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents one of the three language fonts contained in the ThemeFonts collection
/// </summary>
public enum MsoFontLanguageIndex
{
  /// <summary>
  /// Represents the Latin font face. msoThemeComplexScript2 Represents the font face for Complex Script languages.
  /// The Complex Script language collection supports Arabic, Georgian, Hebrew, Indian, Thai and Vietnamese
  /// alphabets.
  /// </summary>
  Latin = 1,
  /// <summary>
  /// Represents one of the three language fonts contained in the ThemeFonts collection
  /// </summary>
  ComplexScript,
  /// <summary>
  /// Represents the East Asian font face. East Asian Languages include Simplified Chinese, Traditional Chinese,
  /// Japanese, and Korean.
  /// </summary>
  EastAsian
}
