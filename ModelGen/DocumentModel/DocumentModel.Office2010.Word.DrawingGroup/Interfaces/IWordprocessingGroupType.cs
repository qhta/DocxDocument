namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the WordprocessingGroupType Class.
/// </summary>
public interface IWordprocessingGroupType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public INonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
