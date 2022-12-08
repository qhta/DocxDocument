namespace DocumentModel.Drawings;

/// <summary>
/// Graphic Object Data.
/// </summary>
public class GraphicDataImpl: ModelElementImpl, GraphicData
{
  public DocumentFormat.OpenXml.Drawing.GraphicData? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.GraphicData?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Uniform Resource Identifier
  /// </summary>
  public String? Uri
  {
    get;
    set;
  }
  
}
