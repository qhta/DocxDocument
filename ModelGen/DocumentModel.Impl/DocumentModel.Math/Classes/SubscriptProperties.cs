namespace DocumentModel.Math;

/// <summary>
/// Subscript Properties.
/// </summary>
public partial class SubscriptPropertiesImpl: ModelElementImpl, SubscriptProperties
{
  public DocumentFormat.OpenXml.Math.SubscriptProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubscriptProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubscriptPropertiesImpl(): base() {}
  
  public SubscriptPropertiesImpl(DocumentFormat.OpenXml.Math.SubscriptProperties openXmlElement): base(openXmlElement)
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
