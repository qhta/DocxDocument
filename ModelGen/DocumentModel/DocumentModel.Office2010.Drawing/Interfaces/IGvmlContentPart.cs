namespace DocumentModel.Office2010.Drawing;

/// <summary>
/// Defines the GvmlContentPart Class.
/// </summary>
public interface IGvmlContentPart // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// bwMode, this property is only available in Office 2010 and later.
  /// </summary>
  public BlackWhiteModeValues? BlackWhiteMode { get ; set; }
  
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? RelationshipId { get ; set; }
  
  /// <summary>
  /// NonVisualContentPartProperties.
  /// </summary>
  public INonVisualContentPartProperties? NonVisualContentPartProperties { get ; set; }
  
  /// <summary>
  /// Transform2D.
  /// </summary>
  public ITransform2D? Transform2D { get ; set; }
  
  /// <summary>
  /// OfficeArtExtensionList.
  /// </summary>
  public IOfficeArtExtensionList? OfficeArtExtensionList { get ; set; }
  
}
