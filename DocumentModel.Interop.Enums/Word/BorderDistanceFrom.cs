namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether a page border is measured from the edge of the page or from the text it surrounds.
/// </summary>
/// <remarks>
/// See `https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.interop.word.wdborderdistancefrom?view=office-pia` for Office interop details.
/// </remarks>
[WordInteropEnumType(typeof(Microsoft.Office.Interop.Word.WdBorderDistanceFrom))]
public enum BorderDistanceFrom
{
  /// <summary>
  /// From the text it surrounds.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderDistanceFrom.wdBorderDistanceFromText))]
  Text = 0,
  /// <summary>
  /// From the edge of the page.
  /// </summary>
  [WordInteropEnumValue(nameof(Microsoft.Office.Interop.Word.WdBorderDistanceFrom.wdBorderDistanceFromPageEdge))]
  PageEdge = 1
}
