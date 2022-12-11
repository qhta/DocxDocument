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
  public VerticalJustificationKind? Position
  {
    get
    {
      if (OpenXmlElement != null)
      {
        var openXmlElement = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
        return (VerticalJustificationKind?)openXmlElement?.Val?.Value;
      }
      return null;
    }
    set
    {
      if (OpenXmlElement != null)
      {
        var item = OpenXmlElement.GetFirstChild<DocumentFormat.OpenXml.Math.Position>();
        if (item != null)
        {
          if (value is not null)
            item.Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value;
          else
            item.Remove();
        }
        else
        {
          if (value is not null)
          {
            item = new DocumentFormat.OpenXml.Math.Position{ Val = (DocumentFormat.OpenXml.Math.VerticalJustificationValues?)value };
            OpenXmlElement.AddChild(item);
          }
        }
      }
    }
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
