namespace DocumentModel.Math;

/// <summary>
/// Upper Limit Properties.
/// </summary>
public class LimitUpperPropertiesImpl: ModelElementImpl, LimitUpperProperties
{
  public DocumentFormat.OpenXml.Math.LimitUpperProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.LimitUpperProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
