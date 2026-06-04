namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies where a paragraph should be relocated in relation to its current position.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdrelocate?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdRelocate))]
public enum Relocate
{
  /// <summary>
  /// Above the previous visible paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelocate.wdRelocateUp))]
  Up = 0,
  /// <summary>
  /// Below the next visible paragraph.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdRelocate.wdRelocateDown))]
  Down = 1
}
