namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerCacheCrossFilterValues enumeration.
/// </summary>
public enum SlicerCacheCrossFilter
{
  /// <summary>
  /// none.
  /// </summary>
  [XmlEnum("none")]
  None,
  
  /// <summary>
  /// showItemsWithDataAtTop.
  /// </summary>
  [XmlEnum("showItemsWithDataAtTop")]
  ShowItemsWithDataAtTop,
  
  /// <summary>
  /// showItemsWithNoData.
  /// </summary>
  [XmlEnum("showItemsWithNoData")]
  ShowItemsWithNoData,
  
}
