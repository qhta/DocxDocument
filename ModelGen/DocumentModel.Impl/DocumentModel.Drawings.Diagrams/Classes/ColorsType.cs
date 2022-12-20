namespace DocumentModel.Drawings.Diagrams;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public partial class ColorsTypeImpl: ModelElementImpl, ColorsType
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public ColorsTypeImpl(): base() {}
  
  public ColorsTypeImpl(DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind? Method
  {
    get => (DocumentModel.Drawings.Diagrams.ColorApplicationMethodKind?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues?)value;
    }
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public DocumentModel.Drawings.Diagrams.HueDirectionKind? HueDirection
  {
    get => (DocumentModel.Drawings.Diagrams.HueDirectionKind?)OpenXmlElement?.HueDirection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HueDirection = (DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues?)value;
    }
  }
  
}
