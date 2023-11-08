namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableStyleOverrideValues enumeration.
/// </summary>
public enum TableStyleOverrideKind
{
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;wholeTable&quot;.
  /// </summary>
  WholeTable,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstRow&quot;.
  /// </summary>
  FirstRow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lastRow&quot;.
  /// </summary>
  LastRow,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;firstCol&quot;.
  /// </summary>
  FirstColumn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;lastCol&quot;.
  /// </summary>
  LastColumn,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band1Vert&quot;.
  /// </summary>
  Band1Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band2Vert&quot;.
  /// </summary>
  Band2Vertical,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band1Horz&quot;.
  /// </summary>
  Band1Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;band2Horz&quot;.
  /// </summary>
  Band2Horizontal,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;neCell&quot;.
  /// </summary>
  NorthEastCell,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;nwCell&quot;.
  /// </summary>
  NorthWestCell,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;seCell&quot;.
  /// </summary>
  SouthEastCell,
  
  
  /// <summary>
  ///   When the item is serialized out as xml, its value is &quot;swCell&quot;.
  /// </summary>
  SouthWestCell,
  
}
