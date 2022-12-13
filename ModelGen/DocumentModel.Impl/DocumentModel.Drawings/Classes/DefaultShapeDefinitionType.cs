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
  
  public DefaultShapeDefinitionTypeImpl(): base() {}
  
  public DefaultShapeDefinitionTypeImpl(DocumentFormat.OpenXml.Drawing.DefaultShapeDefinitionType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public virtual DocumentModel.Drawings.ShapeProperties? ShapeProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public virtual DocumentModel.Drawings.BodyProperties? BodyProperties
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public virtual DocumentModel.Drawings.ListStyle? ListStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public virtual DocumentModel.Drawings.ShapeStyle? ShapeStyle
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public virtual DocumentModel.Drawings.ExtensionList? ExtensionList
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
