namespace DocumentModel.Wordprocessing;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocPartGalleryValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum DocPartGalleryKind
{
  /// <summary>
  ///   Structured IDocument Tag Placeholder Text Gallery.
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
  ///   IDocument Parts Gallery.
  /// </summary>
  DocumentPart,

  /// <summary>
  ///   Cover IPage Gallery.
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
  ///   IPage Numbers Gallery.
  /// </summary>
  IPageNumber,

  /// <summary>
  ///   ITable Gallery.
  /// </summary>
  ITable,

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
  ///   IPage Numbers At Top Gallery.
  /// </summary>
  PageNumberTop,

  /// <summary>
  ///   IPage Numbers At Bottom Gallery.
  /// </summary>
  PageNumberBottom,

  /// <summary>
  ///   IPage Numbers At Margins Gallery.
  /// </summary>
  PageNumberMargins,

  /// <summary>
  ///   ITable of Contents Gallery.
  /// </summary>
  ITableOfContents,

  /// <summary>
  ///   IBibliography Gallery.
  /// </summary>
  IBibliography,

  /// <summary>
  ///   Custom Quick Parts Gallery.
  /// </summary>
  CustomQuickParts,

  /// <summary>
  ///   Custom Cover IPage Gallery.
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
  ///   Custom IPage Number Gallery.
  /// </summary>
  CustomPageNumber,

  /// <summary>
  ///   Custom ITable Gallery.
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
  ///   Custom IPage Number At Top Gallery.
  /// </summary>
  CustomPageNumberTop,

  /// <summary>
  ///   Custom IPage Number At Bottom Gallery.
  /// </summary>
  CustomPageNumberBottom,

  /// <summary>
  ///   Custom IPage Number At Margins Gallery.
  /// </summary>
  CustomPageNumberMargin,

  /// <summary>
  ///   Custom ITable of Contents Gallery.
  /// </summary>
  CustomTableOfContents,

  /// <summary>
  ///   Custom IBibliography Gallery.
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
