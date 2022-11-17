namespace DocumentModel.Wordprocessing;

public enum DocPartGallery
{

  [XmlEnum("placeholder")]
  Placeholder,

  [XmlEnum("any")]
  Any,

  [XmlEnum("default")]
  Default,

  [XmlEnum("docParts")]
  DocumentPart,

  [XmlEnum("coverPg")]
  CoverPage,

  [XmlEnum("eq")]
  Equation,

  [XmlEnum("ftrs")]
  Footer,

  [XmlEnum("hdrs")]
  Header,

  [XmlEnum("pgNum")]
  PageNumber,

  [XmlEnum("tbls")]
  Table,

  [XmlEnum("watermarks")]
  WaterMark,

  [XmlEnum("autoTxt")]
  AutoText,

  [XmlEnum("txtBox")]
  TextBox,

  [XmlEnum("pgNumT")]
  PageNumberTop,

  [XmlEnum("pgNumB")]
  PageNumberBottom,

  [XmlEnum("pgNumMargins")]
  PageNumberMargins,

  [XmlEnum("tblOfContents")]
  TableOfContents,

  [XmlEnum("bib")]
  Bibliography,

  [XmlEnum("custQuickParts")]
  CustomQuickParts,

  [XmlEnum("custCoverPg")]
  CustomCoverPage,

  [XmlEnum("custEq")]
  CustomEquation,

  [XmlEnum("custFtrs")]
  CustomFooter,

  [XmlEnum("custHdrs")]
  CustomHeaders,

  [XmlEnum("custPgNum")]
  CustomPageNumber,

  [XmlEnum("custTbls")]
  CustomTable,

  [XmlEnum("custWatermarks")]
  CustomWatermark,

  [XmlEnum("custAutoTxt")]
  CustomAutoText,

  [XmlEnum("custTxtBox")]
  CustomTextBox,

  [XmlEnum("custPgNumT")]
  CustomPageNumberTop,

  [XmlEnum("custPgNumB")]
  CustomPageNumberBottom,

  [XmlEnum("custPgNumMargins")]
  CustomPageNumberMargin,

  [XmlEnum("custTblOfContents")]
  CustomTableOfContents,

  [XmlEnum("custBib")]
  CustomBibliography,

  [XmlEnum("custom1")]
  Custom1,

  [XmlEnum("custom2")]
  Custom2,

  [XmlEnum("custom3")]
  Custom3,

  [XmlEnum("custom4")]
  Custom4,

  [XmlEnum("custom5")]
  Custom5,
}
