namespace DocumentModel.Vml;

/// <summary>
/// Shape Group.
/// </summary>
public interface Group
{
  /// <summary>
  /// hralign
  /// </summary>
  public HorizontalRuleAlignmentKind? HorizontalAlignment { get ; set; }
  
  /// <summary>
  /// insetmode
  /// </summary>
  public InsetMarginKind? InsetMode { get ; set; }
  
  /// <summary>
  /// Group Diagram Type
  /// </summary>
  public EditAsKind? EditAs { get ; set; }
  
}
