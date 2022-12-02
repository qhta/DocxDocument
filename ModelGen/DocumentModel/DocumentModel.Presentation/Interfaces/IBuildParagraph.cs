namespace DocumentModel.Presentation;

/// <summary>
/// Build Paragraph.
/// </summary>
public interface IBuildParagraph // : DocumentModel.ITypedOpenXmlCompositeElement
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public String? ShapeId { get ; set; }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public UInt32? GroupId { get ; set; }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public Boolean? UiExpand { get ; set; }
  
  /// <summary>
  /// Build Types
  /// </summary>
  public ParagraphBuildKind? Build { get ; set; }
  
  /// <summary>
  /// Build Level
  /// </summary>
  public UInt32? BuildLevel { get ; set; }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public Boolean? AnimateBackground { get ; set; }
  
  /// <summary>
  /// Auto Update Animation Background
  /// </summary>
  public Boolean? AutoAnimateBackground { get ; set; }
  
  /// <summary>
  /// Reverse
  /// </summary>
  public Boolean? Reverse { get ; set; }
  
  /// <summary>
  /// Auto Advance Time
  /// </summary>
  public String? AutoAdvance { get ; set; }
  
  /// <summary>
  /// Template effects.
  /// </summary>
  public ITemplateList? TemplateList { get ; set; }
  
}
