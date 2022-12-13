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
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
