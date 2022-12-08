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
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
