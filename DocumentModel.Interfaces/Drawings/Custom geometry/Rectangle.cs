namespace DocumentModel.Drawings;

/// <summary>
///   This element specifies the rectangular bounding box for text within a custom geometry.
///   The default for this rectangle is the bounding box for the shape.
///   This can be modified using this elements four attributes to inset or extend the text bounding box.
/// </summary>
/// <remarks>
/// Text specified to reside within this shape text rectangle can flow outside this bounding box.
/// Depending on the autofit options within the txBody element the text might not entirely reside within this shape text rectangle. 
/// </remarks>
public interface Rectangle
{
  /// <summary>
  ///   Left position of the rectangle.
  /// </summary>
  public string? Left { get; set; }

  /// <summary>
  ///   Top position of the rectangle.
  /// </summary>
  public string? Top { get; set; }

  /// <summary>
  ///   Right position of the rectangle.
  /// </summary>
  public string? Right { get; set; }

  /// <summary>
  ///   Bottom position of the rectangle.
  /// </summary>
  public string? Bottom { get; set; }
}