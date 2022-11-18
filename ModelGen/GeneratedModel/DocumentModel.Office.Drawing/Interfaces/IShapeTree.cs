namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the ShapeTree Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IGroupShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IGroupShape))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IGroupShapeNonVisualProperties))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IShape))]
public interface IShapeTree // : DocumentFormat.OpenXml.Office.Drawing.GroupShapeType
{
  /// <summary>
  /// GroupShapeNonVisualProperties.
  /// </summary>
  public IGroupShapeNonVisualProperties? GroupShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// GroupShapeProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.IGroupShapeProperties? GroupShapeProperties { get ; set; }
  
}
