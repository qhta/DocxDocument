namespace DocumentModel.Presentation;

/// <summary>
/// Shape.
/// </summary>
public interface Shape // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Use Background Fill
  /// </summary>
  public Boolean? UseBackgroundFill { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Style.
  /// </summary>
  public ShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public TextBody? TextBody { get ; set; }
  
  /// <summary>
  /// ExtensionListWithModification.
  /// </summary>
  public ExtensionListWithModification? ExtensionListWithModification { get ; set; }
  
}
