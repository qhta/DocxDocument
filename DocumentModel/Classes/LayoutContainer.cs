namespace DocumentModel;

/// <summary>
/// Defines the LayoutContainer Class.
/// </summary>
public partial class LayoutContainer
{
  /// <summary>
  /// id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }
  
  /// <summary>
  /// tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }
  
  /// <summary>
  /// align, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? Align { get; set; }
  
  /// <summary>
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? Expand { get; set; }
  
  /// <summary>
  /// layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.LayoutChildrenKind? LayoutChildren { get; set; }
  
  public DocumentModel.BackstageGroupButton? BackstageGroupButton { get; set; }
  
  public DocumentModel.BackstageCheckBox? BackstageCheckBox { get; set; }
  
  public DocumentModel.BackstageEditBox? BackstageEditBox { get; set; }
  
  public DocumentModel.BackstageDropDown? BackstageDropDown { get; set; }
  
  public DocumentModel.RadioGroup? RadioGroup { get; set; }
  
  public DocumentModel.BackstageComboBox? BackstageComboBox { get; set; }
  
  public DocumentModel.Hyperlink? Hyperlink { get; set; }
  
  public DocumentModel.BackstageLabelControl? BackstageLabelControl { get; set; }
  
  public DocumentModel.GroupBox? GroupBox { get; set; }
  
  public DocumentModel.LayoutContainer? ChildLayoutContainer { get; set; }
  
  public DocumentModel.ImageControl? ImageControl { get; set; }
  
}
