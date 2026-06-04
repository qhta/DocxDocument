namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of building block.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuildingblocktypes?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdBuildingBlockTypes")]
public enum WdBuildingBlockTypes
{
  /// <summary>
  /// Quick parts building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeQuickParts")]
  QuickParts = 1,
  /// <summary>
  /// Cover page building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCoverPage")]
  CoverPage = 2,
  /// <summary>
  /// Equation building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeEquations")]
  Equations = 3,
  /// <summary>
  /// Custom footers building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeFooters")]
  Footers = 4,
  /// <summary>
  /// Custom headers building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeHeaders")]
  Headers = 5,
  /// <summary>
  /// Page numbering building block.
  /// </summary>
  [WordInteropEnumValue("wdTypePageNumber")]
  PageNumber = 6,
  /// <summary>
  /// Table building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeTables")]
  Tables = 7,
  /// <summary>
  /// Watermark building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeWatermarks")]
  Watermarks = 8,
  /// <summary>
  /// Autotext building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeAutoText")]
  AutoText = 9,
  /// <summary>
  /// Text box building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeTextBox")]
  TextBox = 10,
  /// <summary>
  /// Building block for page numbering on the top of the page.
  /// </summary>
  [WordInteropEnumValue("wdTypePageNumberTop")]
  PageNumberTop = 11,
  /// <summary>
  /// Building block for page numbering on the bottom of the page.
  /// </summary>
  [WordInteropEnumValue("wdTypePageNumberBottom")]
  PageNumberBottom = 12,
  /// <summary>
  /// Page numbering building block.
  /// </summary>
  [WordInteropEnumValue("wdTypePageNumberPage")]
  PageNumberPage = 13,
  /// <summary>
  /// Table of contents building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeTableOfContents")]
  TableOfContents = 14,
  /// <summary>
  /// Custom quick parts building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomQuickParts")]
  CustomQuickParts = 15,
  /// <summary>
  /// Custom cover page building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomCoverPage")]
  CustomCoverPage = 16,
  /// <summary>
  /// Custom equations building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomEquations")]
  CustomEquations = 17,
  /// <summary>
  /// Custom footers building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomFooters")]
  CustomFooters = 18,
  /// <summary>
  /// Custom headers building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomHeaders")]
  CustomHeaders = 19,
  /// <summary>
  /// Custom page numbering building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomPageNumber")]
  CustomPageNumber = 20,
  /// <summary>
  /// Custom table building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomTables")]
  CustomTables = 21,
  /// <summary>
  /// Custom watermark building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomWatermarks")]
  CustomWatermarks = 22,
  /// <summary>
  /// Custom autotext building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomAutoText")]
  CustomAutoText = 23,
  /// <summary>
  /// Custom text box building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomTextBox")]
  CustomTextBox = 24,
  /// <summary>
  /// Building block for custom page numbering on the top of the page.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomPageNumberTop")]
  CustomPageNumberTop = 25,
  /// <summary>
  /// Building block for custom page numbering on the bottom of the page.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomPageNumberBottom")]
  CustomPageNumberBottom = 26,
  /// <summary>
  /// Custom page numbering building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomPageNumberPage")]
  CustomPageNumberPage = 27,
  /// <summary>
  /// Custom table of contents building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomTableOfContents")]
  CustomTableOfContents = 28,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustom1")]
  Custom1 = 29,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustom2")]
  Custom2 = 30,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustom3")]
  Custom3 = 31,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustom4")]
  Custom4 = 32,
  /// <summary>
  /// Custom building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustom5")]
  Custom5 = 33,
  /// <summary>
  /// Bibliography building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeBibliography")]
  Bibliography = 34,
  /// <summary>
  /// Custom bibliography building block.
  /// </summary>
  [WordInteropEnumValue("wdTypeCustomBibliography")]
  CustomBibliography = 35
}
