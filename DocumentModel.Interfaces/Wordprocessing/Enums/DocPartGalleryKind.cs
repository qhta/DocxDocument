namespace DocumentModel.Wordprocessing;

/// <summary>
///   Defines the DocPartGalleryValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocPartGalleryKind
{
  /// <summary>
  ///   Structured Document Tag Placeholder Text Gallery.
  /// </summary>
  Placeholder,
  /// <summary>
  ///   All Galleries.
  /// </summary>
  Any,
  /// <summary>
  ///   No Gallery Classification.
  /// </summary>
  Default,
  /// <summary>
  ///   Document Parts Gallery.
  /// </summary>
  DocumentPart,
  /// <summary>
  ///   Cover Page Gallery.
  /// </summary>
  CoverPage,
  /// <summary>
  ///   Equations Gallery.
  /// </summary>
  Equation,
  /// <summary>
  ///   Footers Gallery.
  /// </summary>
  Footer,
  /// <summary>
  ///   Headers Gallery.
  /// </summary>
  Header,
  /// <summary>
  ///   Page Numbers Gallery.
  /// </summary>
  PageNumber,
  /// <summary>
  ///   Table Gallery.
  /// </summary>
  Table,
  /// <summary>
  ///   Watermark Gallery.
  /// </summary>
  WaterMark,
  /// <summary>
  ///   AutoText Gallery.
  /// </summary>
  AutoText,
  /// <summary>
  ///   Text Box Gallery.
  /// </summary>
  TextBox,
  /// <summary>
  ///   Page Numbers At Top Gallery.
  /// </summary>
  PageNumberTop,
  /// <summary>
  ///   Page Numbers At Bottom Gallery.
  /// </summary>
  PageNumberBottom,
  /// <summary>
  ///   Page Numbers At Margins Gallery.
  /// </summary>
  PageNumberMargins,
  /// <summary>
  ///   Table of Contents Gallery.
  /// </summary>
  TableOfContents,
  /// <summary>
  ///   Bibliography Gallery.
  /// </summary>
  Bibliography,
  /// <summary>
  ///   Custom Quick Parts Gallery.
  /// </summary>
  CustomQuickParts,
  /// <summary>
  ///   Custom Cover Page Gallery.
  /// </summary>
  CustomCoverPage,
  /// <summary>
  ///   Custom Equation Gallery.
  /// </summary>
  CustomEquation,
  /// <summary>
  ///   Custom Footer Gallery.
  /// </summary>
  CustomFooter,
  /// <summary>
  ///   Custom Header Gallery.
  /// </summary>
  CustomHeaders,
  /// <summary>
  ///   Custom Page Number Gallery.
  /// </summary>
  CustomPageNumber,
  /// <summary>
  ///   Custom Table Gallery.
  /// </summary>
  CustomTable,
  /// <summary>
  ///   Custom Watermark Gallery.
  /// </summary>
  CustomWatermark,
  /// <summary>
  ///   Custom AutoText Gallery.
  /// </summary>
  CustomAutoText,
  /// <summary>
  ///   Custom Text Box Gallery.
  /// </summary>
  CustomTextBox,
  /// <summary>
  ///   Custom Page Number At Top Gallery.
  /// </summary>
  CustomPageNumberTop,
  /// <summary>
  ///   Custom Page Number At Bottom Gallery.
  /// </summary>
  CustomPageNumberBottom,
  /// <summary>
  ///   Custom Page Number At Margins Gallery.
  /// </summary>
  CustomPageNumberMargin,
  /// <summary>
  ///   Custom Table of Contents Gallery.
  /// </summary>
  CustomTableOfContents,
  /// <summary>
  ///   Custom Bibliography Gallery.
  /// </summary>
  CustomBibliography,
  /// <summary>
  ///   Custom 1 Gallery.
  /// </summary>
  Custom1,
  /// <summary>
  ///   Custom 2 Gallery.
  /// </summary>
  Custom2,
  /// <summary>
  ///   Custom 3 Gallery.
  /// </summary>
  Custom3,
  /// <summary>
  ///   Custom 4 Gallery.
  /// </summary>
  Custom4,
  /// <summary>
  ///   Custom 5 Gallery.
  /// </summary>
  Custom5
}