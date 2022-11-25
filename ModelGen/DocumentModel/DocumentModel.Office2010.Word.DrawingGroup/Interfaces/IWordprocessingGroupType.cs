namespace DocumentModel.Office2010.Word.DrawingGroup;

/// <summary>
/// Defines the WordprocessingGroupType Class.
/// </summary>
public interface IWordprocessingGroupType // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.INonVisualDrawingProperties? NonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// NonVisualGroupDrawingShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.INonVisualGroupDrawingShapeProperties? NonVisualGroupDrawingShapeProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.DrawingGroup.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
