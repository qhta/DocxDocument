namespace DocumentModel.Vml;

/// <summary>
/// Shape Fill Extended Properties.
/// </summary>
public class FillExtendedPropertiesImpl: ModelElementImpl, FillExtendedProperties
{
  public DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Vml.Office.FillExtendedProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// VML Extension Handling Behavior
  /// </summary>
  public ExtensionHandlingBehaviorKind? Extension
  {
    get => (ExtensionHandlingBehaviorKind?)OpenXmlElement?.Extension?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Extension = (DocumentFormat.OpenXml.Vml.ExtensionHandlingBehaviorValues?)value;
    }
  }
  
  /// <summary>
  /// Fill Type
  /// </summary>
  public FillKind? Type
  {
    get => (FillKind?)OpenXmlElement?.Type?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Type = (DocumentFormat.OpenXml.Vml.Office.FillValues?)value;
    }
  }
  
}
