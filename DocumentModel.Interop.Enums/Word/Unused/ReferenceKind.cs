namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the information to include in a cross-reference.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencekind?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdReferenceKind")]
public enum ReferenceKind
{
  /// <summary>
  /// Insert label, number, and any additional caption of specified equation, figure, or table.
  /// </summary>
  [InteropEnumValue("wdEntireCaption")]
  EntireCaption = 2,
  /// <summary>
  /// Insert only the label and number of the specified equation, figure, or table.
  /// </summary>
  [InteropEnumValue("wdOnlyLabelAndNumber")]
  OnlyLabelAndNumber = 3,
  /// <summary>
  /// Insert only the caption text of the specified equation, figure, or table.
  /// </summary>
  [InteropEnumValue("wdOnlyCaptionText")]
  OnlyCaptionText = 4,
  /// <summary>
  /// Insert footnote reference mark.
  /// </summary>
  [InteropEnumValue("wdFootnoteNumber")]
  FootnoteNumber = 5,
  /// <summary>
  /// Insert endnote reference mark.
  /// </summary>
  [InteropEnumValue("wdEndnoteNumber")]
  EndnoteNumber = 6,
  /// <summary>
  /// Insert page number of specified item.
  /// </summary>
  [InteropEnumValue("wdPageNumber")]
  PageNumber = 7,
  /// <summary>
  /// Insert the word "Above" or the word "Below" as appropriate.
  /// </summary>
  [InteropEnumValue("wdPosition")]
  Position = 15,
  /// <summary>
  /// Insert formatted footnote reference mark.
  /// </summary>
  [InteropEnumValue("wdFootnoteNumberFormatted")]
  FootnoteNumberFormatted = 16,
  /// <summary>
  /// Insert formatted endnote reference mark.
  /// </summary>
  [InteropEnumValue("wdEndnoteNumberFormatted")]
  EndnoteNumberFormatted = 17,
  /// <summary>
  /// Insert complete heading or paragraph number.
  /// </summary>
  [InteropEnumValue("wdNumberFullContext")]
  NumberFullContext = -4,
  /// <summary>
  /// Insert heading or paragraph without its relative position in the outline numbered list.
  /// </summary>
  [InteropEnumValue("wdNumberNoContext")]
  NumberNoContext = -3,
  /// <summary>
  /// Insert heading or paragraph with as much of its relative position in the outline numbered list as necessary to
  /// identify the item.
  /// </summary>
  [InteropEnumValue("wdNumberRelativeContext")]
  NumberRelativeContext = -2,
  /// <summary>
  /// Insert text value of the specified item. For example, insert text of the specified heading.
  /// </summary>
  [InteropEnumValue("wdContentText")]
  ContentText = -1
}
