namespace DocumentModel.Math;

/// <summary>
/// Superscript Properties.
/// </summary>
public class SuperscriptPropertiesImpl: ModelElementImpl, SuperscriptProperties
{
  public DocumentFormat.OpenXml.Math.SuperscriptProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SuperscriptProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SuperscriptPropertiesImpl(): base() {}
  
  public SuperscriptPropertiesImpl(DocumentFormat.OpenXml.Math.SuperscriptProperties openXmlElement): base(openXmlElement)
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
