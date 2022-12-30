namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public partial class ContentPart
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId { get; set; }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BlackWhiteMode { get; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.NonVisualContentPartProperties? NonVisualContentPartProperties { get; set; }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.Transform2D? Transform2D { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.ChartDrawings.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
