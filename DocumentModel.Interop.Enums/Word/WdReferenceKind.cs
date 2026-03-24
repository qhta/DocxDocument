namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the information to include in a cross-reference.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdreferencekind?view=office-pia` for Office interop details.
/// </remarks>
public enum WdReferenceKind
{
  /// <summary>
  /// Insert label, number, and any additional caption of specified equation, figure, or table.
  /// </summary>
  EntireCaption = 2,
  /// <summary>
  /// Insert only the label and number of the specified equation, figure, or table.
  /// </summary>
  OnlyLabelAndNumber = 3,
  /// <summary>
  /// Insert only the caption text of the specified equation, figure, or table.
  /// </summary>
  OnlyCaptionText = 4,
  /// <summary>
  /// Insert footnote reference mark.
  /// </summary>
  FootnoteNumber = 5,
  /// <summary>
  /// Insert endnote reference mark.
  /// </summary>
  EndnoteNumber = 6,
  /// <summary>
  /// Insert page number of specified item.
  /// </summary>
  PageNumber = 7,
  /// <summary>
  /// Insert the word "Above" or the word "Below" as appropriate.
  /// </summary>
  Position = 15,
  /// <summary>
  /// Insert formatted footnote reference mark.
  /// </summary>
  FootnoteNumberFormatted = 16,
  /// <summary>
  /// Insert formatted endnote reference mark.
  /// </summary>
  EndnoteNumberFormatted = 17,
  /// <summary>
  /// Insert complete heading or paragraph number.
  /// </summary>
  NumberFullContext = -4,
  /// <summary>
  /// Insert heading or paragraph without its relative position in the outline numbered list.
  /// </summary>
  NumberNoContext = -3,
  /// <summary>
  /// Insert heading or paragraph with as much of its relative position in the outline numbered list as necessary to
  /// identify the item.
  /// </summary>
  NumberRelativeContext = -2,
  /// <summary>
  /// Insert text value of the specified item. For example, insert text of the specified heading.
  /// </summary>
  ContentText = -1
}
