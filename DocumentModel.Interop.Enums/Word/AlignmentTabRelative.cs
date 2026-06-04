namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether Microsoft Office Word calculates the alignment for a tab relative to the section margins or
/// the paragraph indents.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdalignmenttabrelative?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType("WdAlignmentTabRelative")]
public enum AlignmentTabRelative
{
  /// <summary>
  /// Word calculates tab alignment relative to the margins
  /// </summary>
  [WordInteropEnumValue("wdMargin")]
  Margin = 0,
  /// <summary>
  /// Word calculates tab alignment relative to the paragraph indents.
  /// </summary>
  [WordInteropEnumValue("wdIndent")]
  Indent = 1
}
