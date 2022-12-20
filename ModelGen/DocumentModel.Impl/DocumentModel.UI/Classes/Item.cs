namespace DocumentModel.UI;

/// <summary>
/// Defines the Item Class.
/// </summary>
public partial class ItemImpl: ModelElementImpl, Item
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office.CustomUI.Item? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.CustomUI.Item?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public ItemImpl(): base() {}
  
  public ItemImpl(DocumentFormat.OpenXml.Office.CustomUI.Item openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id
  /// </summary>
  public String? Id
  {
    get => (System.String?)OpenXmlElement?.Id?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Id = (System.String?)value;
    }
  }
  
  /// <summary>
  /// label
  /// </summary>
  public String? Label
  {
    get => (System.String?)OpenXmlElement?.Label?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Label = (System.String?)value;
    }
  }
  
  /// <summary>
  /// image
  /// </summary>
  public String? Image
  {
    get => (System.String?)OpenXmlElement?.Image?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Image = (System.String?)value;
    }
  }
  
  /// <summary>
  /// imageMso
  /// </summary>
  public String? ImageMso
  {
    get => (System.String?)OpenXmlElement?.ImageMso?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.ImageMso = (System.String?)value;
    }
  }
  
  /// <summary>
  /// screentip
  /// </summary>
  public String? Screentip
  {
    get => (System.String?)OpenXmlElement?.Screentip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Screentip = (System.String?)value;
    }
  }
  
  /// <summary>
  /// supertip
  /// </summary>
  public String? Supertip
  {
    get => (System.String?)OpenXmlElement?.Supertip?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Supertip = (System.String?)value;
    }
  }
  
}
