namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public partial class ContentPart2
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawings.BlackWhiteMode? BlackWhiteMode { get; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId { get; set; }
  
  /// <summary>
  /// WordNonVisualContentPartShapeProperties.
  /// </summary>
  public DocumentModel.Wordprocessing.WordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Wordprocessing.Transform2D? Transform2D { get; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Wordprocessing.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
