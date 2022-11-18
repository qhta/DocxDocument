namespace DocumentModel.Office2010.Excel;

/// <summary>
/// Defines the SlicerStyleTypeValues enumeration.
/// </summary>
public enum SlicerStyleType
{
  /// <summary>
  /// unselectedItemWithData.
  /// </summary>
  [XmlEnum("unselectedItemWithData")]
  UnselectedItemWithData,
  
  /// <summary>
  /// selectedItemWithData.
  /// </summary>
  [XmlEnum("selectedItemWithData")]
  SelectedItemWithData,
  
  /// <summary>
  /// unselectedItemWithNoData.
  /// </summary>
  [XmlEnum("unselectedItemWithNoData")]
  UnselectedItemWithNoData,
  
  /// <summary>
  /// selectedItemWithNoData.
  /// </summary>
  [XmlEnum("selectedItemWithNoData")]
  SelectedItemWithNoData,
  
  /// <summary>
  /// hoveredUnselectedItemWithData.
  /// </summary>
  [XmlEnum("hoveredUnselectedItemWithData")]
  HoveredUnselectedItemWithData,
  
  /// <summary>
  /// hoveredSelectedItemWithData.
  /// </summary>
  [XmlEnum("hoveredSelectedItemWithData")]
  HoveredSelectedItemWithData,
  
  /// <summary>
  /// hoveredUnselectedItemWithNoData.
  /// </summary>
  [XmlEnum("hoveredUnselectedItemWithNoData")]
  HoveredUnselectedItemWithNoData,
  
  /// <summary>
  /// hoveredSelectedItemWithNoData.
  /// </summary>
  [XmlEnum("hoveredSelectedItemWithNoData")]
  HoveredSelectedItemWithNoData,
  
}
