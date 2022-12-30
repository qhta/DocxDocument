namespace DocumentModel.Wordprocessing.DrawingShape;

/// <summary>
/// Defines the WordprocessingShape Class.
/// </summary>
public partial class WordprocessingShape
{
  /// <summary>
  /// normalEastAsianFlow, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? NormalEastAsianFlow { get; set; }
  
  /// <summary>
  /// NonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.DrawingShape.NonVisualDrawingProperties? NonVisualDrawingProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.NonVisualDrawingShapeProperties? NonVisualDrawingShapeProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.NonVisualConnectorProperties? NonVisualConnectorProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.ShapeProperties? ShapeProperties { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.ShapeStyle? ShapeStyle { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.TextBoxInfo2? TextBoxInfo2 { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.LinkedTextBox? LinkedTextBox { get; set; }
  
  public DocumentModel.Wordprocessing.DrawingShape.TextBodyProperties? TextBodyProperties { get; set; }
  
}
