namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableStyleOverrideValues enumeration.
/// </summary>
public enum TableStyleOverrideKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wholeTable&quot;.
  /// </summary>
  [EnumString("wholeTable")]
  WholeTable,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstRow&quot;.
  /// </summary>
  [EnumString("firstRow")]
  FirstRow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lastRow&quot;.
  /// </summary>
  [EnumString("lastRow")]
  LastRow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstCol&quot;.
  /// </summary>
  [EnumString("firstCol")]
  FirstColumn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lastCol&quot;.
  /// </summary>
  [EnumString("lastCol")]
  LastColumn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band1Vert&quot;.
  /// </summary>
  [EnumString("band1Vert")]
  Band1Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band2Vert&quot;.
  /// </summary>
  [EnumString("band2Vert")]
  Band2Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band1Horz&quot;.
  /// </summary>
  [EnumString("band1Horz")]
  Band1Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band2Horz&quot;.
  /// </summary>
  [EnumString("band2Horz")]
  Band2Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;neCell&quot;.
  /// </summary>
  [EnumString("neCell")]
  NorthEastCell,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nwCell&quot;.
  /// </summary>
  [EnumString("nwCell")]
  NorthWestCell,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;seCell&quot;.
  /// </summary>
  [EnumString("seCell")]
  SouthEastCell,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;swCell&quot;.
  /// </summary>
  [EnumString("swCell")]
  SouthWestCell,
  
}
