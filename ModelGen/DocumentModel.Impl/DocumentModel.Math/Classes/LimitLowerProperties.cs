namespace DocumentModel.Math;

/// <summary>
/// Lower Limit Properties.
/// </summary>
public partial class LimitLowerPropertiesImpl: ModelElementImpl, LimitLowerProperties
{
  public DocumentFormat.OpenXml.Math.LimitLowerProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitLowerProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LimitLowerPropertiesImpl(): base() {}
  
  public LimitLowerPropertiesImpl(DocumentFormat.OpenXml.Math.LimitLowerProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
