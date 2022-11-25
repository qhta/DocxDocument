namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
public interface IContentPart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.Drawing.BlackWhiteMode? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public System.String? RelationshipId { get ; set; }
  
  /// <summary>
  /// WordNonVisualContentPartShapeProperties.
  /// </summary>
  public DocumentModel.Office2010.Word.IWordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.Word.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? OfficeArtExtensionList { get ; set; }
  
}
