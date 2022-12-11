namespace DocumentModel.Math;

/// <summary>
/// Superscript Properties.
/// </summary>
public class SuperscriptPropertiesImpl: ModelElementImpl, SuperscriptProperties
{
  public DocumentFormat.OpenXml.Math.SuperscriptProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SuperscriptProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SuperscriptPropertiesImpl(): base() {}
  
  public SuperscriptPropertiesImpl(DocumentFormat.OpenXml.Math.SuperscriptProperties openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
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
