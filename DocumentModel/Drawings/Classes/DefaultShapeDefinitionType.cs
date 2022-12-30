namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public partial class DefaultShapeDefinitionType
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public DocumentModel.Drawings.ShapeProperties? ShapeProperties { get; set; }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public DocumentModel.Drawings.BodyProperties? BodyProperties { get; set; }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public DocumentModel.Drawings.ListStyle? ListStyle { get; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawings.ShapeStyle? ShapeStyle { get; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ExtensionList? ExtensionList { get; set; }
  
}
