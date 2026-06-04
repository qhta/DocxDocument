namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether the document text should wrap on both sides of the specified shape, on either the left or
/// right side only, or on the side of the shape that is farthest from the page margin.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.word.wdwrapsidetype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdWrapSideType))]
public enum WrapSideType
{
  /// <summary>
  /// Both sides of the specified shape.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapSideType.wdWrapBoth))]
  Both = 0,
  /// <summary>
  /// Left side of shape only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapSideType.wdWrapLeft))]
  Left = 1,
  /// <summary>
  /// Right side of shape only.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapSideType.wdWrapRight))]
  Right = 2,
  /// <summary>
  /// Side of the shape that is farthest from the page margin.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdWrapSideType.wdWrapLargest))]
  Largest = 3
}
