namespace DocumentModel.Math;

/// <summary>
/// Subscript Properties.
/// </summary>
public class SubscriptPropertiesImpl: ModelElementImpl, SubscriptProperties
{
  public DocumentFormat.OpenXml.Math.SubscriptProperties? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Math.SubscriptProperties?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public SubscriptPropertiesImpl(): base() {}
  
  public SubscriptPropertiesImpl(DocumentFormat.OpenXml.Math.SubscriptProperties openXmlElement): base(openXmlElement)
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
