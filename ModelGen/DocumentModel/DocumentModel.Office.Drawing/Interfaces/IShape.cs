namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Shape Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IShapeProperties))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IShapeStyle))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.ITextBody))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.ITransform2D))]
[ChildElementInfo(typeof(DocumentModel.Office.Drawing.IShapeNonVisualProperties))]
public interface IShape // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public string? ModelId { get ; set; }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public IShapeNonVisualProperties? ShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Office.Drawing.IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public DocumentModel.Office.Drawing.ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office.Drawing.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
