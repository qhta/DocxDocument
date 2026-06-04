namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting for indexes in a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexformat?view=office-pia` for Office interop details.
/// </remarks>
[InteropEnumType("Microsoft.Office.Interop.Word.WdIndexFormat")]
public enum IndexFormat
{
  /// <summary>
  /// From template.
  /// </summary>
  [InteropEnumValue("wdIndexTemplate")]
  Template = 0,
  /// <summary>
  /// Classic.
  /// </summary>
  [InteropEnumValue("wdIndexClassic")]
  Classic = 1,
  /// <summary>
  /// Fancy.
  /// </summary>
  [InteropEnumValue("wdIndexFancy")]
  Fancy = 2,
  /// <summary>
  /// Modern.
  /// </summary>
  [InteropEnumValue("wdIndexModern")]
  Modern = 3,
  /// <summary>
  /// Bulleted.
  /// </summary>
  [InteropEnumValue("wdIndexBulleted")]
  Bulleted = 4,
  /// <summary>
  /// Formal.
  /// </summary>
  [InteropEnumValue("wdIndexFormal")]
  Formal = 5,
  /// <summary>
  /// Simple.
  /// </summary>
  [InteropEnumValue("wdIndexSimple")]
  Simple = 6
}
