namespace DocumentModel.Office2016.Excel;

public enum FeatureType
{

  [XmlEnum("dataValidation")]
  DataValidation,

  [XmlEnum("hyperlink")]
  Hyperlink,

  [XmlEnum("rowColVisualOps")]
  RowColVisualOps,

  [XmlEnum("freezePanes")]
  FreezePanes,

  [XmlEnum("sparklines")]
  Sparklines,

  [XmlEnum("hideUnhideSheet")]
  HideUnhideSheet,

  [XmlEnum("showGridlinesHeadings")]
  ShowGridlinesHeadings,

  [XmlEnum("comment")]
  Comment,

  [XmlEnum("outlines")]
  Outlines,

  [XmlEnum("drawingElement")]
  DrawingElement,

  [XmlEnum("autoFilter")]
  AutoFilter,

  [XmlEnum("pivotTable")]
  PivotTable,

  [XmlEnum("future")]
  Future,
}
