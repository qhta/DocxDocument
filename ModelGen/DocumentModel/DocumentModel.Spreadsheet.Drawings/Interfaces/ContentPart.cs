namespace DocumentModel.Spreadsheet.Drawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public interface ContentPart // : DocumentModel.BaseTypes.ModelElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId { get ; set; }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// ExcelNonVisualContentPartShapeProperties.
  /// </summary>
  public ExcelNonVisualContentPartShapeProperties? ExcelNonVisualContentPartShapeProperties { get ; set; }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public Transform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
