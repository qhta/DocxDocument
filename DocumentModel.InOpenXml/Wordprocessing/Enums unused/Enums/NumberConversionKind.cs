namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the type of number conversion when converting numbers to text.
/// </summary>
public enum NumberConversionKind
{
  /// <summary>Convert to Arabic numerals</summary>
  Arabic = 0,
  /// <summary>Convert to lowercase letters</summary>
  LowerLetter = 1,
  /// <summary>Convert to uppercase letters</summary>
  UpperLetter = 2,
  /// <summary>Convert to lowercase Roman numerals</summary>
  LowerRoman = 3,
  /// <summary>Convert to uppercase Roman numerals</summary>
  UpperRoman = 4
}