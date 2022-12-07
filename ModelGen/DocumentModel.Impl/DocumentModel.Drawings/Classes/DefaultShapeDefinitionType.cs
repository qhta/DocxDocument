namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public class DefaultShapeDefinitionTypeImpl: ModelElement<DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType>, DefaultShapeDefinitionType
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public virtual ShapeProperties6? ShapeProperties
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
  public virtual ShapeStyle2? ShapeStyle
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
