namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the TableStyleOverrideValues enumeration.
/// </summary>
public enum TableStyleOverrideKind
{
  /// <summary>
  ///   Whole table formatting.
  /// </summary>
  WholeTable,

  /// <summary>
  ///   First Row Conditional Formatting.
  /// </summary>
  FirstRow,

  /// <summary>
  ///   Last table row formatting.
  /// </summary>
  LastRow,

  /// <summary>
  ///   First Column Conditional Formatting.
  /// </summary>
  FirstColumn,

  /// <summary>
  ///   Last table column formatting.
  /// </summary>
  LastColumn,

  /// <summary>
  ///   Banded Column Conditional Formatting.
  /// </summary>
  Band1Vertical,

  /// <summary>
  ///   Even Column Stripe Conditional Formatting.
  /// </summary>
  Band2Vertical,

  /// <summary>
  ///   Banded Row Conditional Formatting.
  /// </summary>
  Band1Horizontal,

  /// <summary>
  ///   Even Row Stripe Conditional Formatting.
  /// </summary>
  Band2Horizontal,

  /// <summary>
  ///   Top right table cell formatting.
  /// </summary>
  NorthEastCell,

  /// <summary>
  ///   Top left table cell formatting.
  /// </summary>
  NorthWestCell,

  /// <summary>
  ///   Bottom right table cell formatting.
  /// </summary>
  SouthEastCell,

  /// <summary>
  ///   Bottom left table cell formatting.
  /// </summary>
  SouthWestCell
}