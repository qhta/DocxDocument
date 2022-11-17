namespace DocumentModel.Office2010.Excel;

public enum SlicerStyleType
{

  [XmlEnum("unselectedItemWithData")]
  UnselectedItemWithData,

  [XmlEnum("selectedItemWithData")]
  SelectedItemWithData,

  [XmlEnum("unselectedItemWithNoData")]
  UnselectedItemWithNoData,

  [XmlEnum("selectedItemWithNoData")]
  SelectedItemWithNoData,

  [XmlEnum("hoveredUnselectedItemWithData")]
  HoveredUnselectedItemWithData,

  [XmlEnum("hoveredSelectedItemWithData")]
  HoveredSelectedItemWithData,

  [XmlEnum("hoveredUnselectedItemWithNoData")]
  HoveredUnselectedItemWithNoData,

  [XmlEnum("hoveredSelectedItemWithNoData")]
  HoveredSelectedItemWithNoData,
}
