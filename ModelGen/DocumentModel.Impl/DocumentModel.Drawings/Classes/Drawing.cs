namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Drawing Class.
/// </summary>
public class DrawingImpl: ModelElementImpl, Drawing
{
  public DocumentFormat.OpenXml.Office.Drawing.Drawing? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Drawing?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public ShapeTree? ShapeTree
  {
    get;
    set;
  }
  
}
