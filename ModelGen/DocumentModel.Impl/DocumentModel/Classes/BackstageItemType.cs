namespace DocumentModel;

/// <summary>
/// Defines the BackstageItemType Class.
/// </summary>
public partial class BackstageItemTypeImpl: ModelElementImpl, BackstageItemType
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2010.CustomUI.BackstageItemType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2010.CustomUI.BackstageItemType?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public BackstageItemTypeImpl(): base() {}
  
  public BackstageItemTypeImpl(DocumentFormat.OpenXml.Office2010.CustomUI.BackstageItemType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
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
  /// label, this property is only available in Office 2010 and later.
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
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel
  {
    get => (System.String?)OpenXmlElement?.GetLabel?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.GetLabel = (System.String?)value;
    }
  }
  
}
