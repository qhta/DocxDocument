namespace DocumentModel.Presentation;

/// <summary>
/// Build Paragraph.
/// </summary>
[ChildElementInfo(typeof(DocumentModel.Presentation.ITemplateList))]
public class BuildParagraph: IBuildParagraph
{
  /// <summary>
  /// Shape ID
  /// </summary>
  public string? ShapeId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Group ID
  /// </summary>
  public uint? GroupId
  {
    get;
    set;
  }
  
  /// <summary>
  /// Expand UI
  /// </summary>
  public bool? UiExpand
  {
    get;
    set;
  }
  
  /// <summary>
  /// Build Types
  /// </summary>
  public ParagraphBuildValues? Build
  {
    get;
    set;
  }
  
  /// <summary>
  /// Build Level
  /// </summary>
  public uint? BuildLevel
  {
    get;
    set;
  }
  
  /// <summary>
  /// Animate Background
  /// </summary>
  public bool? AnimateBackground
  {
    get;
    set;
  }
  
  /// <summary>
  /// Auto Update Animation Background
  /// </summary>
  public bool? AutoAnimateBackground
  {
    get;
    set;
  }
  
  /// <summary>
  /// Reverse
  /// </summary>
  public bool? Reverse
  {
    get;
    set;
  }
  
  /// <summary>
  /// Auto Advance Time
  /// </summary>
  public string? AutoAdvance
  {
    get;
    set;
  }
  
  /// <summary>
  /// Template effects.
  /// </summary>
  public ITemplateList? TemplateList
  {
    get;
    set;
  }
  
}
