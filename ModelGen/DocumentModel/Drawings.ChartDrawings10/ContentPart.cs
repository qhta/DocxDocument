namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the ContentPart Class.
/// </summary>
public partial class ContentPart
{
  
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId { get; set; }
  
  
  /// <summary>
  ///   NonVisualContentPartProperties.
  /// </summary>
  public DMDCD10.NonVisualContentPartProperties? NonVisualContentPartProperties { get; set; }
  
  
  /// <summary>
  ///   ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DMDCD10.ApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get; set; }
  
  
  /// <summary>
  ///   Transform2D.
  /// </summary>
  public DMDCD10.Transform2D? Transform2D { get; set; }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  public DMDCD10.OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
  
}
