namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the type of building block.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdbuildingblocktypes?view=office-pia` for Office interop details.
/// </remarks>
public enum BuildingBlockTypes
{
  /// <summary>
  /// Quick parts building block.
  /// </summary>
  QuickParts = 1,
  /// <summary>
  /// Cover page building block.
  /// </summary>
  CoverPage = 2,
  /// <summary>
  /// Equation building block.
  /// </summary>
  Equations = 3,
  /// <summary>
  /// Custom footers building block.
  /// </summary>
  Footers = 4,
  /// <summary>
  /// Custom headers building block.
  /// </summary>
  Headers = 5,
  /// <summary>
  /// Page numbering building block.
  /// </summary>
  PageNumber = 6,
  /// <summary>
  /// Table building block.
  /// </summary>
  Tables = 7,
  /// <summary>
  /// Watermark building block.
  /// </summary>
  Watermarks = 8,
  /// <summary>
  /// Autotext building block.
  /// </summary>
  AutoText = 9,
  /// <summary>
  /// Text box building block.
  /// </summary>
  TextBox = 10,
  /// <summary>
  /// Building block for page numbering on the top of the page.
  /// </summary>
  PageNumberTop = 11,
  /// <summary>
  /// Building block for page numbering on the bottom of the page.
  /// </summary>
  PageNumberBottom = 12,
  /// <summary>
  /// Page numbering building block.
  /// </summary>
  PageNumberPage = 13,
  /// <summary>
  /// Table of contents building block.
  /// </summary>
  TableOfContents = 14,
  /// <summary>
  /// Custom quick parts building block.
  /// </summary>
  CustomQuickParts = 15,
  /// <summary>
  /// Custom cover page building block.
  /// </summary>
  CustomCoverPage = 16,
  /// <summary>
  /// Custom equations building block.
  /// </summary>
  CustomEquations = 17,
  /// <summary>
  /// Custom footers building block.
  /// </summary>
  CustomFooters = 18,
  /// <summary>
  /// Custom headers building block.
  /// </summary>
  CustomHeaders = 19,
  /// <summary>
  /// Custom page numbering building block.
  /// </summary>
  CustomPageNumber = 20,
  /// <summary>
  /// Custom table building block.
  /// </summary>
  CustomTables = 21,
  /// <summary>
  /// Custom watermark building block.
  /// </summary>
  CustomWatermarks = 22,
  /// <summary>
  /// Custom autotext building block.
  /// </summary>
  CustomAutoText = 23,
  /// <summary>
  /// Custom text box building block.
  /// </summary>
  CustomTextBox = 24,
  /// <summary>
  /// Building block for custom page numbering on the top of the page.
  /// </summary>
  CustomPageNumberTop = 25,
  /// <summary>
  /// Building block for custom page numbering on the bottom of the page.
  /// </summary>
  CustomPageNumberBottom = 26,
  /// <summary>
  /// Custom page numbering building block.
  /// </summary>
  CustomPageNumberPage = 27,
  /// <summary>
  /// Custom table of contents building block.
  /// </summary>
  CustomTableOfContents = 28,
  /// <summary>
  /// Custom building block.
  /// </summary>
  Custom1 = 29,
  /// <summary>
  /// Custom building block.
  /// </summary>
  Custom2 = 30,
  /// <summary>
  /// Custom building block.
  /// </summary>
  Custom3 = 31,
  /// <summary>
  /// Custom building block.
  /// </summary>
  Custom4 = 32,
  /// <summary>
  /// Custom building block.
  /// </summary>
  Custom5 = 33,
  /// <summary>
  /// Bibliography building block.
  /// </summary>
  Bibliography = 34,
  /// <summary>
  /// Custom bibliography building block.
  /// </summary>
  CustomBibliography = 35
}
