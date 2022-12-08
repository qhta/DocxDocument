namespace DocumentModel.Drawings;

/// <summary>
/// Defines the NonVisualGroupProperties Class.
/// </summary>
public class NonVisualGroupPropertiesImpl: ModelElementImpl, NonVisualGroupProperties
{
  public DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office2013.Drawing.NonVisualGroupProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// isLegacyGroup, this property is only available in Office 2013 and later.
  /// </summary>
  public Boolean? IsLegacyGroup
  {
    get;
    set;
  }
  
}
