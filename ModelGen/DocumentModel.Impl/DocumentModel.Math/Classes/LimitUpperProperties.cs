namespace DocumentModel.Math;

/// <summary>
/// Upper Limit Properties.
/// </summary>
public partial class LimitUpperPropertiesImpl: ModelElementImpl, LimitUpperProperties
{
  public DocumentFormat.OpenXml.Math.LimitUpperProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitUpperProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LimitUpperPropertiesImpl(): base() {}
  
  public LimitUpperPropertiesImpl(DocumentFormat.OpenXml.Math.LimitUpperProperties openXmlElement): base(openXmlElement)
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
