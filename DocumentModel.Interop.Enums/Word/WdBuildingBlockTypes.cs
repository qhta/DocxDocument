namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of building block.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuildingblocktypes?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdBuildingBlockTypes")]
public enum WdBuildingBlockTypes
{
  /// <summary>
  /// Quick parts building block.
  /// </summary>
  [InteropEnumValue("wdTypeQuickParts")]
  QuickParts = 1,
  /// <summary>
  /// Cover page building block.
  /// </summary>
  [InteropEnumValue("wdTypeCoverPage")]
  CoverPage = 2,
  /// <summary>
  /// Equation building block.
  /// </summary>
  [InteropEnumValue("wdTypeEquations")]
  Equations = 3,
  /// <summary>
  /// Custom footers building block.
  /// </summary>
  [InteropEnumValue("wdTypeFooters")]
  Footers = 4,
  /// <summary>
  /// Custom headers building block.
  /// </summary>
  [InteropEnumValue("wdTypeHeaders")]
  Headers = 5,
  /// <summary>
  /// Page numbering building block.
  /// </summary>
  [InteropEnumValue("wdTypePageNumber")]
  PageNumber = 6,
  /// <summary>
  /// Table building block.
  /// </summary>
  [InteropEnumValue("wdTypeTables")]
  Tables = 7,
  /// <summary>
  /// Watermark building block.
  /// </summary>
  [InteropEnumValue("wdTypeWatermarks")]
  Watermarks = 8,
  /// <summary>
  /// Autotext building block.
  /// </summary>
  [InteropEnumValue("wdTypeAutoText")]
  AutoText = 9,
  /// <summary>
  /// Text box building block.
  /// </summary>
  [InteropEnumValue("wdTypeTextBox")]
  TextBox = 10,
  /// <summary>
  /// Building block for page numbering on the top of the page.
  /// </summary>
  [InteropEnumValue("wdTypePageNumberTop")]
  PageNumberTop = 11,
  /// <summary>
  /// Building block for page numbering on the bottom of the page.
  /// </summary>
  [InteropEnumValue("wdTypePageNumberBottom")]
  PageNumberBottom = 12,
  /// <summary>
  /// Page numbering building block.
  /// </summary>
  [InteropEnumValue("wdTypePageNumberPage")]
  PageNumberPage = 13,
  /// <summary>
  /// Table of contents building block.
  /// </summary>
  [InteropEnumValue("wdTypeTableOfContents")]
  TableOfContents = 14,
  /// <summary>
  /// Custom quick parts building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomQuickParts")]
  CustomQuickParts = 15,
  /// <summary>
  /// Custom cover page building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomCoverPage")]
  CustomCoverPage = 16,
  /// <summary>
  /// Custom equations building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomEquations")]
  CustomEquations = 17,
  /// <summary>
  /// Custom footers building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomFooters")]
  CustomFooters = 18,
  /// <summary>
  /// Custom headers building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomHeaders")]
  CustomHeaders = 19,
  /// <summary>
  /// Custom page numbering building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomPageNumber")]
  CustomPageNumber = 20,
  /// <summary>
  /// Custom table building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomTables")]
  CustomTables = 21,
  /// <summary>
  /// Custom watermark building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomWatermarks")]
  CustomWatermarks = 22,
  /// <summary>
  /// Custom autotext building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomAutoText")]
  CustomAutoText = 23,
  /// <summary>
  /// Custom text box building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomTextBox")]
  CustomTextBox = 24,
  /// <summary>
  /// Building block for custom page numbering on the top of the page.
  /// </summary>
  [InteropEnumValue("wdTypeCustomPageNumberTop")]
  CustomPageNumberTop = 25,
  /// <summary>
  /// Building block for custom page numbering on the bottom of the page.
  /// </summary>
  [InteropEnumValue("wdTypeCustomPageNumberBottom")]
  CustomPageNumberBottom = 26,
  /// <summary>
  /// Custom page numbering building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomPageNumberPage")]
  CustomPageNumberPage = 27,
  /// <summary>
  /// Custom table of contents building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomTableOfContents")]
  CustomTableOfContents = 28,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustom1")]
  Custom1 = 29,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustom2")]
  Custom2 = 30,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustom3")]
  Custom3 = 31,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustom4")]
  Custom4 = 32,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustom5")]
  Custom5 = 33,
  /// <summary>
  /// Bibliography building block.
  /// </summary>
  [InteropEnumValue("wdTypeBibliography")]
  Bibliography = 34,
  /// <summary>
  /// Custom bibliography building block.
  /// </summary>
  [InteropEnumValue("wdTypeCustomBibliography")]
  CustomBibliography = 35
}
