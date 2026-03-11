namespace DocumentModel.Wordprocessing;
/// <summary>
///   Defines the DocPartGalleryValues enumeration.
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
[OpenXmlEnumType(typeof(DXW.DocPartGalleryValues))]
public enum DocPartGalleryType
{
  /// <summary>
  ///   Structured Document Tag Placeholder Text Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Placeholder))]
  Placeholder,
  /// <summary>
  ///   All Galleries.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Any))]
  Any,
  /// <summary>
  ///   No Gallery Classification.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Default))]
  Default,
  /// <summary>
  ///   Document Parts Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.DocumentPart))]
  DocumentPart,
  /// <summary>
  ///   Cover Page Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CoverPage))]
  CoverPage,
  /// <summary>
  ///   Equations Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Equation))]
  Equation,
  /// <summary>
  ///   Footers Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Footer))]
  Footer,
  /// <summary>
  ///   Headers Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Header))]
  Header,
  /// <summary>
  ///   Page Numbers Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.PageNumber))]
  PageNumber,
  /// <summary>
  ///   Table Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Table))]
  Table,
  /// <summary>
  ///   Watermark Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.WaterMark))]
  WaterMark,
  /// <summary>
  ///   AutoText Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.AutoText))]
  AutoText,
  /// <summary>
  ///   Text Box Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.TextBox))]
  TextBox,
  /// <summary>
  ///   Page Numbers At Top Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.PageNumberTop))]
  PageNumberTop,
  /// <summary>
  ///   Page Numbers At Bottom Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.PageNumberBottom))]
  PageNumberBottom,
  /// <summary>
  ///   Page Numbers At Margins Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.PageNumberMargins))]
  PageNumberMargins,
  /// <summary>
  ///   Table of Contents Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.TableOfContents))]
  TableOfContents,
  /// <summary>
  ///   Bibliography Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Bibliography))]
  Bibliography,
  /// <summary>
  ///   Custom Quick Parts Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomQuickParts))]
  CustomQuickParts,
  /// <summary>
  ///   Custom Cover Page Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomCoverPage))]
  CustomCoverPage,
  /// <summary>
  ///   Custom Equation Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomEquation))]
  CustomEquation,
  /// <summary>
  ///   Custom Footer Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomFooter))]
  CustomFooter,
  /// <summary>
  ///   Custom Header Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomHeaders))]
  CustomHeaders,
  /// <summary>
  ///   Custom Page Number Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomPageNumber))]
  CustomPageNumber,
  /// <summary>
  ///   Custom Table Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomTable))]
  CustomTable,
  /// <summary>
  ///   Custom Watermark Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomWatermark))]
  CustomWatermark,
  /// <summary>
  ///   Custom AutoText Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomAutoText))]
  CustomAutoText,
  /// <summary>
  ///   Custom Text Box Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomTextBox))]
  CustomTextBox,
  /// <summary>
  ///   Custom Page Number At Top Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomPageNumberTop))]
  CustomPageNumberTop,
  /// <summary>
  ///   Custom Page Number At Bottom Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomPageNumberBottom))]
  CustomPageNumberBottom,
  /// <summary>
  ///   Custom Page Number At Margins Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomPageNumberMargin))]
  CustomPageNumberMargin,
  /// <summary>
  ///   Custom Table of Contents Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomTableOfContents))]
  CustomTableOfContents,
  /// <summary>
  ///   Custom Bibliography Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.CustomBibliography))]
  CustomBibliography,
  /// <summary>
  ///   Custom 1 Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Custom1))]
  Custom1,
  /// <summary>
  ///   Custom 2 Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Custom2))]
  Custom2,
  /// <summary>
  ///   Custom 3 Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Custom3))]
  Custom3,
  /// <summary>
  ///   Custom 4 Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Custom4))]
  Custom4,
  /// <summary>
  ///   Custom 5 Gallery.
  /// </summary>
  [OpenXmlEnumValue(nameof(DXW.DocPartGalleryValues.Custom5))]
  Custom5
}