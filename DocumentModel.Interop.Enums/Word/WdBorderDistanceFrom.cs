namespace DocumentModel.Interop.Word;

/// <summary>
/// Specifies whether a page border is measured from the edge of the page or from the text it surrounds.
/// </summary>
public enum WdBorderDistanceFrom
{
  /// <summary>
  /// From the text it surrounds.
  /// </summary>
  wdBorderDistanceFromText = unchecked((int)0),
  /// <summary>
  /// From the edge of the page.
  /// </summary>
  wdBorderDistanceFromPageEdge = unchecked((int)1)
}
