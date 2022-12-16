namespace DocumentModel.Drawings.Office;

/// <summary>
/// Defines the Shape Class.
/// </summary>
public interface Shape
{
  /// <summary>
  /// modelId, this property is only available in Office 2010 and later.
  /// </summary>
  public String? ModelId { get ; set; }
  
  /// <summary>
  /// ShapeNonVisualProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeNonVisualProperties? ShapeNonVisualProperties { get ; set; }
  
  /// <summary>
  /// ShapeProperties.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeProperties? ShapeProperties { get ; set; }
  
  /// <summary>
  /// ShapeStyle.
  /// </summary>
  public DocumentModel.Drawings.Office.ShapeStyle? ShapeStyle { get ; set; }
  
  /// <summary>
  /// TextBody.
  /// </summary>
  public DocumentModel.Drawings.Office.TextBody? TextBody { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawings.Office.Transform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Office.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
