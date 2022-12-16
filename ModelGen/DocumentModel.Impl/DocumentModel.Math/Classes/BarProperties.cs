namespace DocumentModel.Math;

/// <summary>
/// Bar Properties.
/// </summary>
public class BarPropertiesImpl: ModelElementImpl, BarProperties
{
  public DocumentFormat.OpenXml.Math.BarProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.BarProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public BarPropertiesImpl(): base() {}
  
  public BarPropertiesImpl(DocumentFormat.OpenXml.Math.BarProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Position (Bar).
  /// </summary>
  public DocumentModel.Math.VerticalJustificationKind? Position
  {
    get => (DocumentModel.Math.VerticalJustificationKind?)OpenXmlElement?.Position?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.Position != null)
        {
          if (value is not null)
            OpenXmlElement.Position.Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value;
          else
            OpenXmlElement.Position = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.Position = new DocumentFormat.OpenXml.Math.Position{ Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value };
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public DocumentModel.Math.ControlProperties? ControlProperties
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          return new DocumentModel.Math.ControlPropertiesImpl(item);
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.ControlProperties>();
        if (item != null)
          item.Remove();
        if (value is not null)
        {
          item = (value as DocumentModel.Math.ControlPropertiesImpl)?.OpenXmlElement;
          if (item != null)
            OpenXmlElement.AddChild(item);
        }
      }
    }
  }
  
}
