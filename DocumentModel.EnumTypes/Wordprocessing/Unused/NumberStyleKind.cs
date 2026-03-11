namespace DocumentModel.Wordprocessing;

/// <summary>
///   Specifies the number style for numbered lists.
/// </summary>
[OpenXmlNotMapped]
public enum NumberStyleKind
{
  /// <summary>Arabic numbers (1, 2, 3...)</summary>
  Arabic = 0,
  /// <summary>Uppercase Roman numerals (I, II, III...)</summary>
  UpperRoman = 1,
  /// <summary>Lowercase Roman numerals (i, ii, iii...)</summary>
  LowerRoman = 2,
  /// <summary>Uppercase letters (A, B, C...)</summary>
  UpperLetter = 3,
  /// <summary>Lowercase letters (a, b, c...)</summary>
  LowerLetter = 4,
  /// <summary>Ordinal numbers (1st, 2nd, 3rd...)</summary>
  Ordinal = 5,
  /// <summary>Cardinal numbers (One, Two, Three...)</summary>
  Cardinal = 6
}