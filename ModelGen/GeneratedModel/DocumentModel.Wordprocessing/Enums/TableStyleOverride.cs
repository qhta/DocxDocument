namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableStyleOverrideValues enumeration.
/// </summary>
public enum TableStyleOverride
{
  /// <summary>
  /// Whole table formatting.
  /// </summary>
  [XmlEnum("wholeTable")]
  WholeTable,
  
  /// <summary>
  /// First Row Conditional Formatting.
  /// </summary>
  [XmlEnum("firstRow")]
  FirstRow,
  
  /// <summary>
  /// Last table row formatting.
  /// </summary>
  [XmlEnum("lastRow")]
  LastRow,
  
  /// <summary>
  /// First Column Conditional Formatting.
  /// </summary>
  [XmlEnum("firstCol")]
  FirstColumn,
  
  /// <summary>
  /// Last table column formatting.
  /// </summary>
  [XmlEnum("lastCol")]
  LastColumn,
  
  /// <summary>
  /// Banded Column Conditional Formatting.
  /// </summary>
  [XmlEnum("band1Vert")]
  Band1Vertical,
  
  /// <summary>
  /// Even Column Stripe Conditional Formatting.
  /// </summary>
  [XmlEnum("band2Vert")]
  Band2Vertical,
  
  /// <summary>
  /// Banded Row Conditional Formatting.
  /// </summary>
  [XmlEnum("band1Horz")]
  Band1Horizontal,
  
  /// <summary>
  /// Even Row Stripe Conditional Formatting.
  /// </summary>
  [XmlEnum("band2Horz")]
  Band2Horizontal,
  
  /// <summary>
  /// Top right table cell formatting.
  /// </summary>
  [XmlEnum("neCell")]
  NorthEastCell,
  
  /// <summary>
  /// Top left table cell formatting.
  /// </summary>
  [XmlEnum("nwCell")]
  NorthWestCell,
  
  /// <summary>
  /// Bottom right table cell formatting.
  /// </summary>
  [XmlEnum("seCell")]
  SouthEastCell,
  
  /// <summary>
  /// Bottom left table cell formatting.
  /// </summary>
  [XmlEnum("swCell")]
  SouthWestCell,
  
}
