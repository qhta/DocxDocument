namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object.
/// </summary>
public class GraphicImpl: ModelElementImpl, Graphic
{
  public DocumentFormat.OpenXml.Drawing.Graphic? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Graphic?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Graphic Object Data.
  /// </summary>
  public GraphicData? GraphicData
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
