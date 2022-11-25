namespace DocumentModel.Presentation;

/// <summary>
/// Build Paragraph.
/// </summary>
public interface IBuildParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public System.String? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public System.UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public System.Boolean? UiExpand { get ; set; }
  
  /// <summary>
  /// Build Types
  /// </summary>
  public DocumentModel.Presentation.ParagraphBuildKind? Build { get ; set; }
  
  /// <summary>
  /// Build Level
  /// </summary>
  public System.UInt32? BuildLevel { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public System.Boolean? AnimateBackground { get ; set; }
  
  /// <summary>
  /// Auto Update Animation Background
  /// </summary>
  public System.Boolean? AutoAnimateBackground { get ; set; }
  
  /// <summary>
  /// Reverse
  /// </summary>
  public System.Boolean? Reverse { get ; set; }
  
  /// <summary>
  /// Auto Advance Time
  /// </summary>
  public System.String? AutoAdvance { get ; set; }
  
  /// <summary>
  /// Template effects.
  /// </summary>
  public DocumentModel.BaseTypes.ModelElement? TemplateList { get ; set; }
  
}
