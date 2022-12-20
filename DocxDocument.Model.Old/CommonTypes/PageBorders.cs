namespace DocxDocument.Model;

/// <summary>
/// Represents borders assigned to a page.
/// </summary>
public class PageBorders : FrameBorders
{
  /// <summary>
  /// indicates if page borders are displayed in front of the document text.
  /// </summary>
  public bool? AlwaysInFront { get; set; }

  /// <summary> 
  /// Returns or sets a value that indicates whether the specified page border is measured from the edge of the page or from the text it surrounds. Read/write WdBorderDistanceFrom.
  ///</summary> 
  public BorderDistanceFrom? DistanceFrom { get; set; }
}