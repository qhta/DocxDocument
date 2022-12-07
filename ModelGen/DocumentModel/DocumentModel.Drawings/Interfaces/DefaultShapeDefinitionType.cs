namespace DocumentModel.Drawings;

/// <summary>
/// Defines the DefaultShapeDefinitionType Class.
/// </summary>
public interface DefaultShapeDefinitionType
{
  /// <summary>
  /// Visual Properties.
  /// </summary>
  public ShapeProperties6? ShapeProperties { get ; set; }
  
  /// <summary>
  /// BodyProperties.
  /// </summary>
  public BodyProperties? BodyProperties { get ; set; }
  
  /// <summary>
  /// ListStyle.
  /// </summary>
  public ListStyle? ListStyle { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle2? ShapeStyle { get ; set; }
  
  /// <summary>
  /// ExtensionList.
  /// </summary>
  public ExtensionList1? ExtensionList { get ; set; }
  
}
