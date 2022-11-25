namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? ModelId { get ; set; }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Office.Drawing.IShapeNonVisualProperties? ShapeNonVisualProperties { get ; set; }
  
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
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}
