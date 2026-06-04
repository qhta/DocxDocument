namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies the formatting for indexes in a document.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdindexformat?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdIndexFormat")]
public enum IndexFormat
{
  /// <summary>
  /// From template.
  /// </summary>
  [WordInteropEnumValue("wdIndexTemplate")]
  Template = 0,
  /// <summary>
  /// Classic.
  /// </summary>
  [WordInteropEnumValue("wdIndexClassic")]
  Classic = 1,
  /// <summary>
  /// Fancy.
  /// </summary>
  [WordInteropEnumValue("wdIndexFancy")]
  Fancy = 2,
  /// <summary>
  /// Modern.
  /// </summary>
  [WordInteropEnumValue("wdIndexModern")]
  Modern = 3,
  /// <summary>
  /// Bulleted.
  /// </summary>
  [WordInteropEnumValue("wdIndexBulleted")]
  Bulleted = 4,
  /// <summary>
  /// Formal.
  /// </summary>
  [WordInteropEnumValue("wdIndexFormal")]
  Formal = 5,
  /// <summary>
  /// Simple.
  /// </summary>
  [WordInteropEnumValue("wdIndexSimple")]
  Simple = 6
}
