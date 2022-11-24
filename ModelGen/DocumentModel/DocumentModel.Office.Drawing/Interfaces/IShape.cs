namespace DocumentModel.Office.Drawing;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public interface IShape // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId { get ; set; }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public IShapeNonVisualProperties? ShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public IShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public IShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public ITextBody? TextBody { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
