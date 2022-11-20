namespace DocumentModel.Office2010.Word;

/// <summary>
/// Defines the ContentPart Class.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IOfficeArtExtensionList))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.ITransform2D))]
[ChildElementInfo(typeof(DocumentModel.Office2010.Word.IWordNonVisualContentPartShapeProperties))]
public interface IContentPart // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? RelationshipId { get ; set; }
  
  /// <summary>
  /// WordNonVisualContentPartShapeProperties.
  /// </summary>
  public IWordNonVisualContentPartShapeProperties? WordNonVisualContentPartShapeProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public DocumentModel.Office2010.Word.ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public DocumentModel.Office2010.Word.IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
