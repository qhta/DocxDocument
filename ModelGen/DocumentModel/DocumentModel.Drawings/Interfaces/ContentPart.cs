namespace DocumentModel.Drawings;

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
  public BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public NonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
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
