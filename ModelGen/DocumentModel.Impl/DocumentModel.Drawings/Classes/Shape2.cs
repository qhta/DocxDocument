namespace DocumentModel.Drawings;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public class Shape2Impl: ModelElementImpl, Shape2
{
  public DocumentFormat.OpenXml.Office.Drawing.Shape? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Office.Drawing.Shape?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public ShapeNonVisualProperties? ShapeNonVisualProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties2? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle2? ShapeStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public TextBody2? TextBody
  {
    get;
    set;
  }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D2? Transform2D
  {
    get;
    set;
  }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList5? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
