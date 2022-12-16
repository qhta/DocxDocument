namespace DocumentModel.Math;

/// <summary>
/// Pre-Sub-Superscript Properties.
/// </summary>
public class PreSubSuperPropertiesImpl: ModelElementImpl, PreSubSuperProperties
{
  public DocumentFormat.OpenXml.Math.PreSubSuperProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.PreSubSuperProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public PreSubSuperPropertiesImpl(): base() {}
  
  public PreSubSuperPropertiesImpl(DocumentFormat.OpenXml.Math.PreSubSuperProperties openXmlElement): base(openXmlElement)
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
