namespace DocumentModel.Math;

/// <summary>
/// Radical Properties.
/// </summary>
public partial class RadicalPropertiesImpl: ModelElementImpl, RadicalProperties
{
  public DocumentFormat.OpenXml.Math.RadicalProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.RadicalProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public RadicalPropertiesImpl(): base() {}
  
  public RadicalPropertiesImpl(DocumentFormat.OpenXml.Math.RadicalProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Hide Degree.
  /// </summary>
  public DocumentModel.Math.BooleanKind? HideDegree
  {
    get => (DocumentModel.Math.BooleanKind?)OpenXmlElement?.HideDegree?.Val?.Value;
    set
    {
      if (OpenXmlElement != null)
      {
        if (OpenXmlElement.HideDegree != null)
        {
          if (value is not null)
            OpenXmlElement.HideDegree.Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value;
          else
            OpenXmlElement.HideDegree = null;
        }
        else
        {
          if (value is not null)
            OpenXmlElement.HideDegree = new DocumentFormat.OpenXml.Math.HideDegree{ Val = (DocumentFormat.OpenXml.Math.BooleanValues?)value };
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
