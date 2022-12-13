namespace DocumentModel.Drawings.Charts;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public interface ContentPart
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
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.NonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawings.Charts.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawings.Charts.Transform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawings.Charts.OfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
