namespace DocumentModel.Wordprocessing;

/// <summary>
/// Sort field types.
/// </summary>
public enum SortFieldKind
{
  /// <summary>Alphanumeric</summary>
  Alphanumeric,
  /// <summary>Numeric</summary>
  Numeric,
  /// <summary>Date</summary>
  Date,
  /// <summary>Japanese JIS</summary>
  JIS,
  /// <summary>Kana</summary>
  Kana,
  /// <summary>Stroke</summary>
  Stroke,
  /// <summary>Syllable</summary>
  Syllable,
  /// <summary>Korean KS</summary>
  KoreanKS
}