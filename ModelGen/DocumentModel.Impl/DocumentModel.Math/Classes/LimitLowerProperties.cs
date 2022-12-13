namespace DocumentModel.Math;

/// <summary>
/// Lower Limit Properties.
/// </summary>
public class LimitLowerPropertiesImpl: ModelElementImpl, LimitLowerProperties
{
  public DocumentFormat.OpenXml.Math.LimitLowerProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitLowerProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LimitLowerPropertiesImpl(): base() {}
  
  public LimitLowerPropertiesImpl(DocumentFormat.OpenXml.Math.LimitLowerProperties openXmlElement): base(openXmlElement)
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
