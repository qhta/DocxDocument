namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public class DrawingImpl: ModelElement<DocumentFormat.OpenXml.Office.Drawing.Drawing>, Drawing
{
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree
  {
    get;
    set;
  }
  
}
