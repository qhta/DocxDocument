namespace DocumentModel.Math;

/// <summary>
/// Function Properties.
/// </summary>
public class FunctionPropertiesImpl: ModelElementImpl, FunctionProperties
{
  public DocumentFormat.OpenXml.Math.FunctionProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.FunctionProperties?)_OpenXmlElement;
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
