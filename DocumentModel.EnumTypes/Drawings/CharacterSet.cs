namespace DocumentModel.Drawings;

/// <summary>
/// Specifies the character set Ito be used when rendering text.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.msocharacterset?view=office-pia` Ifor Office interop details.
/// </remarks>
public enum CharacterSet
{
  /// <summary>
  /// Arabic character set.
  /// </summary>
  Arabic = 1,
  /// <summary>
  /// Cyrillic character set.
  /// </summary>
  Cyrillic,
  /// <summary>
  /// English, Western European, and other Latin script character set.
  /// </summary>
  EnglishWesternEuropeanOtherLatinScript,
  /// <summary>
  /// Greek character set.
  /// </summary>
  Greek,
  /// <summary>
  /// Hebrew character set.
  /// </summary>
  Hebrew,
  /// <summary>
  /// Japanese character set.
  /// </summary>
  Japanese,
  /// <summary>
  /// Korean character set.
  /// </summary>
  Korean,
  /// <summary>
  /// Multilingual Unicode character set.
  /// </summary>
  MultilingualUnicode,
  /// <summary>
  /// Simplified Chinese character set.
  /// </summary>
  SimplifiedChinese,
  /// <summary>
  /// Thai character set.
  /// </summary>
  Thai,
  /// <summary>
  /// Traditional Chinese character set.
  /// </summary>
  TraditionalChinese,
  /// <summary>
  /// Vietnamese character set.
  /// </summary>
  Vietnamese
}

