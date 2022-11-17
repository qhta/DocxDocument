namespace DocumentModel.Spreadsheet;

public enum SheetView
{

  [XmlEnum("normal")]
  Normal,

  [XmlEnum("pageBreakPreview")]
  PageBreakPreview,

  [XmlEnum("pageLayout")]
  PageLayout,
}
