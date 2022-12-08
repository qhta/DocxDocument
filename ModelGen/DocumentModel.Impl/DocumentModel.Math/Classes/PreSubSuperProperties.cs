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
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
