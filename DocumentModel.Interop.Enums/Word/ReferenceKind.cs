namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the information to include in a cross-reference.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencekind?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdReferenceKind")]
public enum ReferenceKind
{
  /// <summary>
  /// Insert label, number, and any additional caption of specified equation, figure, or table.
  /// </summary>
  [WordInteropEnumValue("wdEntireCaption")]
  EntireCaption = 2,
  /// <summary>
  /// Insert only the label and number of the specified equation, figure, or table.
  /// </summary>
  [WordInteropEnumValue("wdOnlyLabelAndNumber")]
  OnlyLabelAndNumber = 3,
  /// <summary>
  /// Insert only the caption text of the specified equation, figure, or table.
  /// </summary>
  [WordInteropEnumValue("wdOnlyCaptionText")]
  OnlyCaptionText = 4,
  /// <summary>
  /// Insert footnote reference mark.
  /// </summary>
  [WordInteropEnumValue("wdFootnoteNumber")]
  FootnoteNumber = 5,
  /// <summary>
  /// Insert endnote reference mark.
  /// </summary>
  [WordInteropEnumValue("wdEndnoteNumber")]
  EndnoteNumber = 6,
  /// <summary>
  /// Insert page number of specified item.
  /// </summary>
  [WordInteropEnumValue("wdPageNumber")]
  PageNumber = 7,
  /// <summary>
  /// Insert the word "Above" or the word "Below" as appropriate.
  /// </summary>
  [WordInteropEnumValue("wdPosition")]
  Position = 15,
  /// <summary>
  /// Insert formatted footnote reference mark.
  /// </summary>
  [WordInteropEnumValue("wdFootnoteNumberFormatted")]
  FootnoteNumberFormatted = 16,
  /// <summary>
  /// Insert formatted endnote reference mark.
  /// </summary>
  [WordInteropEnumValue("wdEndnoteNumberFormatted")]
  EndnoteNumberFormatted = 17,
  /// <summary>
  /// Insert complete heading or paragraph number.
  /// </summary>
  [WordInteropEnumValue("wdNumberFullContext")]
  NumberFullContext = -4,
  /// <summary>
  /// Insert heading or paragraph without its relative position in the outline numbered list.
  /// </summary>
  [WordInteropEnumValue("wdNumberNoContext")]
  NumberNoContext = -3,
  /// <summary>
  /// Insert heading or paragraph with as much of its relative position in the outline numbered list as necessary to
  /// identify the item.
  /// </summary>
  [WordInteropEnumValue("wdNumberRelativeContext")]
  NumberRelativeContext = -2,
  /// <summary>
  /// Insert text value of the specified item. For example, insert text of the specified heading.
  /// </summary>
  [WordInteropEnumValue("wdContentText")]
  ContentText = -1
}
