namespace DocumentModel.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public partial class FillExtendedPropertiesImpl: ModelElementImpl, FillExtendedProperties
{
  [XmlIgnore]
  public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties?)_OpenXmlElement;
    protected set => _OpenXmlElement = value;
  }
  
  public FillExtendedPropertiesImpl(): base() {}
  
  public FillExtendedPropertiesImpl(DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public DocumentModel.Vml.ExtensionHandlingBehaviorKind? Extension
  {
    get => (DocumentModel.Vml.ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public DocumentModel.Vml.FillKind? Type
  {
    get => (DocumentModel.Vml.FillKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.FillValues?)value;
    }
  }
  
}
