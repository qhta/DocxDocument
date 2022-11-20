namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the DocPartGalleryValues enumeration.
/// </summary>
public enum DocPartGalleryValues
{
  /// <summary>
  /// Structured Document Tag Placeholder Text Gallery.
  /// </summary>
  [XmlEnum("placeholder")]
  Placeholder,
  
  /// <summary>
  /// All Galleries.
  /// </summary>
  [XmlEnum("any")]
  Any,
  
  /// <summary>
  /// No Gallery Classification.
  /// </summary>
  [XmlEnum("default")]
  Default,
  
  /// <summary>
  /// Document Parts Gallery.
  /// </summary>
  [XmlEnum("docParts")]
  DocumentPart,
  
  /// <summary>
  /// Cover Page Gallery.
  /// </summary>
  [XmlEnum("coverPg")]
  CoverPage,
  
  /// <summary>
  /// Equations Gallery.
  /// </summary>
  [XmlEnum("eq")]
  Equation,
  
  /// <summary>
  /// Footers Gallery.
  /// </summary>
  [XmlEnum("ftrs")]
  Footer,
  
  /// <summary>
  /// Headers Gallery.
  /// </summary>
  [XmlEnum("hdrs")]
  Header,
  
  /// <summary>
  /// Page Numbers Gallery.
  /// </summary>
  [XmlEnum("pgNum")]
  PageNumber,
  
  /// <summary>
  /// Table Gallery.
  /// </summary>
  [XmlEnum("tbls")]
  Table,
  
  /// <summary>
  /// Watermark Gallery.
  /// </summary>
  [XmlEnum("watermarks")]
  WaterMark,
  
  /// <summary>
  /// AutoText Gallery.
  /// </summary>
  [XmlEnum("autoTxt")]
  AutoText,
  
  /// <summary>
  /// Text Box Gallery.
  /// </summary>
  [XmlEnum("txtBox")]
  TextBox,
  
  /// <summary>
  /// Page Numbers At Top Gallery.
  /// </summary>
  [XmlEnum("pgNumT")]
  PageNumberTop,
  
  /// <summary>
  /// Page Numbers At Bottom Gallery.
  /// </summary>
  [XmlEnum("pgNumB")]
  PageNumberBottom,
  
  /// <summary>
  /// Page Numbers At Margins Gallery.
  /// </summary>
  [XmlEnum("pgNumMargins")]
  PageNumberMargins,
  
  /// <summary>
  /// Table of Contents Gallery.
  /// </summary>
  [XmlEnum("tblOfContents")]
  TableOfContents,
  
  /// <summary>
  /// Bibliography Gallery.
  /// </summary>
  [XmlEnum("bib")]
  Bibliography,
  
  /// <summary>
  /// Custom Quick Parts Gallery.
  /// </summary>
  [XmlEnum("custQuickParts")]
  CustomQuickParts,
  
  /// <summary>
  /// Custom Cover Page Gallery.
  /// </summary>
  [XmlEnum("custCoverPg")]
  CustomCoverPage,
  
  /// <summary>
  /// Custom Equation Gallery.
  /// </summary>
  [XmlEnum("custEq")]
  CustomEquation,
  
  /// <summary>
  /// Custom Footer Gallery.
  /// </summary>
  [XmlEnum("custFtrs")]
  CustomFooter,
  
  /// <summary>
  /// Custom Header Gallery.
  /// </summary>
  [XmlEnum("custHdrs")]
  CustomHeaders,
  
  /// <summary>
  /// Custom Page Number Gallery.
  /// </summary>
  [XmlEnum("custPgNum")]
  CustomPageNumber,
  
  /// <summary>
  /// Custom Table Gallery.
  /// </summary>
  [XmlEnum("custTbls")]
  CustomTable,
  
  /// <summary>
  /// Custom Watermark Gallery.
  /// </summary>
  [XmlEnum("custWatermarks")]
  CustomWatermark,
  
  /// <summary>
  /// Custom AutoText Gallery.
  /// </summary>
  [XmlEnum("custAutoTxt")]
  CustomAutoText,
  
  /// <summary>
  /// Custom Text Box Gallery.
  /// </summary>
  [XmlEnum("custTxtBox")]
  CustomTextBox,
  
  /// <summary>
  /// Custom Page Number At Top Gallery.
  /// </summary>
  [XmlEnum("custPgNumT")]
  CustomPageNumberTop,
  
  /// <summary>
  /// Custom Page Number At Bottom Gallery.
  /// </summary>
  [XmlEnum("custPgNumB")]
  CustomPageNumberBottom,
  
  /// <summary>
  /// Custom Page Number At Margins Gallery.
  /// </summary>
  [XmlEnum("custPgNumMargins")]
  CustomPageNumberMargin,
  
  /// <summary>
  /// Custom Table of Contents Gallery.
  /// </summary>
  [XmlEnum("custTblOfContents")]
  CustomTableOfContents,
  
  /// <summary>
  /// Custom Bibliography Gallery.
  /// </summary>
  [XmlEnum("custBib")]
  CustomBibliography,
  
  /// <summary>
  /// Custom 1 Gallery.
  /// </summary>
  [XmlEnum("custom1")]
  Custom1,
  
  /// <summary>
  /// Custom 2 Gallery.
  /// </summary>
  [XmlEnum("custom2")]
  Custom2,
  
  /// <summary>
  /// Custom 3 Gallery.
  /// </summary>
  [XmlEnum("custom3")]
  Custom3,
  
  /// <summary>
  /// Custom 4 Gallery.
  /// </summary>
  [XmlEnum("custom4")]
  Custom4,
  
  /// <summary>
  /// Custom 5 Gallery.
  /// </summary>
  [XmlEnum("custom5")]
  Custom5,
  
}
