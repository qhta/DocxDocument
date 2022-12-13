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
  
  public DrawingImpl(): base() {}
  
  public DrawingImpl(DocumentFormat.OpenXml.Office.Drawing.Drawing openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// ShapeTree.
  /// </summary>
  public DocumentModel.Drawings.ShapeTree? ShapeTree
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
