namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Shape.
/// </summary>
public interface Shape // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// Reference to Custom Function
  /// </summary>
  public String? Macro { get ; set; }
  
  /// <summary>
  /// Text Link
  /// </summary>
  public String? TextLink { get ; set; }
  
  /// <summary>
  /// Lock Text Flag
  /// </summary>
  public Boolean? LockText { get ; set; }
  
  /// <summary>
  /// Publish to Server Flag
  /// </summary>
  public Boolean? Published { get ; set; }
  
  /// <summary>
  /// Non-Visual Properties for a Shape.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties { get ; set; }
  
  /// <summary>
  /// Shape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public ShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// Shape Text Body.
  /// </summary>
  public TextBody? TextBody { get ; set; }
  
}
