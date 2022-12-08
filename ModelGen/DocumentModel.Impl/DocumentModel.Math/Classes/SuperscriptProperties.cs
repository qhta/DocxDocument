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
  
  /// <summary>
  /// ControlProperties.
  /// </summary>
  public ControlProperties? ControlProperties
  {
    get;
    set;
  }
  
}
