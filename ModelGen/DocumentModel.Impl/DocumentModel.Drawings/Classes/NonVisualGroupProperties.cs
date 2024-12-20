namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public partial class NonVisualGroupPropertiesImpl: ModelElementImpl, NonVisualGroupProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public NonVisualGroupPropertiesImpl(): base() {}
  
  public NonVisualGroupPropertiesImpl(DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsLegacyGroup
  {
    get => (System.Boolean?)OpenXmlElement?.IsLegacyGroup?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.IsLegacyGroup = (System.Boolean?)value;
    }
  }
  
}
