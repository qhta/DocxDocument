namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting for indexes in a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdIndexFormat))]
public enum IndexFormat
{
  /// <summary>
  /// From template.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexTemplate))]
  Template = 0,
  /// <summary>
  /// Classic.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexClassic))]
  Classic = 1,
  /// <summary>
  /// Fancy.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexFancy))]
  Fancy = 2,
  /// <summary>
  /// Modern.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexModern))]
  Modern = 3,
  /// <summary>
  /// Bulleted.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexBulleted))]
  Bulleted = 4,
  /// <summary>
  /// Formal.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexFormal))]
  Formal = 5,
  /// <summary>
  /// Simple.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdIndexFormat.wdIndexSimple))]
  Simple = 6
}
