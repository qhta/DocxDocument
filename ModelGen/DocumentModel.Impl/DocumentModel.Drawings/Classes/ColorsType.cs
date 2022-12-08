namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorsType Class.
/// </summary>
public class ColorsTypeImpl: ModelElementImpl, ColorsType
{
  public DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Diagrams.ColorsType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Color Application Method Type
  /// </summary>
  public ColorApplicationMethodKind? Method
  {
    get => (ColorApplicationMethodKind?)OpenXmlElement?.Method?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Method = (DocumentFormat.OpenXml.Drawing.Diagrams.ColorApplicationMethodValues?)value;
    }
  }
  
  /// <summary>
  /// Hue Direction
  /// </summary>
  public HueDirectionKind? HueDirection
  {
    get => (HueDirectionKind?)OpenXmlElement?.HueDirection?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.HueDirection = (DocumentFormat.OpenXml.Drawing.Diagrams.HueDirectionValues?)value;
    }
  }
  
}
