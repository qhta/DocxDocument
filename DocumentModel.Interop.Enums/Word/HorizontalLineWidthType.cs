namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies how Word interprets the width (length) of the specified horizontal line.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdhorizontallinewidthtype?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdHorizontalLineWidthType))]
public enum HorizontalLineWidthType
{
  /// <summary>
  /// Microsoft Word interprets the width (length) of the specified horizontal line as a fixed value (in points).
  /// This is the default value for horizontal lines added with the AddHorizontalLine method. Setting the Width
  /// property for the InlineShape object associated with a horizontal line sets the WidthType property to this
  /// value.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalLineWidthType.wdHorizontalLineFixedWidth))]
  FixedWidth = -2,
  /// <summary>
  /// Word interprets the width (length) of the specified horizontal line as a percentage of the screen width. This
  /// is the default value for horizontal lines added with the AddHorizontalLineStandard method. Setting the
  /// PercentWidth property on a horizontal line sets the WidthType property to this value.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdHorizontalLineWidthType.wdHorizontalLinePercentWidth))]
  PercentWidth = -1
}
