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
  public virtual ShapeProperties4? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public virtual BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public virtual ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public virtual ShapeStyle2? ShapeStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual ExtensionList4? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
