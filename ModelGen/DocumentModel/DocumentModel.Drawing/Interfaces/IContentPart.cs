namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public interface IContentPart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public DocumentModel.Drawing.INonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// ApplicationNonVisualDrawingProperties.
  /// </summary>
  public DocumentModel.Drawing.IApplicationNonVisualDrawingProperties? ApplicationNonVisualDrawingProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Drawing.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Drawing.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
