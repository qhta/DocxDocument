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
  
  public FunctionPropertiesImpl(): base() {}
  
  public FunctionPropertiesImpl(DocumentFormat.OpenXml.Math.FunctionProperties openXmlElement): base(openXmlElement)
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
