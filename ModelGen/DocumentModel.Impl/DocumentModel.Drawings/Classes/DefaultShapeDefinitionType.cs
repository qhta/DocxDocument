namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public class DefaultShapeDefinitionTypeImpl: ModelElementImpl, DefaultShapeDefinitionType
{
  public DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public virtual ShapeProperties8? ShapeProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public virtual BodyProperties? BodyProperties
  {
    get;
    set;
  }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public virtual ListStyle? ListStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public virtual ShapeStyle1? ShapeStyle
  {
    get;
    set;
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual ExtensionList1? ExtensionList
  {
    get;
    set;
  }
  
}
