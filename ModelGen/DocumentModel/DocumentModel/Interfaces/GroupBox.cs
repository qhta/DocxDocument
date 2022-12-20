namespace DocumentModel;

/// <summary>
/// Defines the GroupBox Class.
/// </summary>
public partial interface GroupBox
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
  /// expand, this property is only available in Office 2010 and later.
  /// </summary>
  public DocumentModel.ExpandKind? Expand { get; set; }
  
  /// <summary>
  /// label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }
  
  /// <summary>
  /// getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }
  
  public DocumentModel.BackstageGroupButton? BackstageGroupButton { get; set; }
  
  public DocumentModel.BackstageCheckBox? BackstageCheckBox { get; set; }
  
  public DocumentModel.BackstageEditBox? BackstageEditBox { get; set; }
  
  public DocumentModel.BackstageDropDown? BackstageDropDown { get; set; }
  
  public DocumentModel.RadioGroup? RadioGroup { get; set; }
  
  public DocumentModel.BackstageComboBox? BackstageComboBox { get; set; }
  
  public DocumentModel.Hyperlink? Hyperlink { get; set; }
  
  public DocumentModel.BackstageLabelControl? BackstageLabelControl { get; set; }
  
  public DocumentModel.GroupBox? ChildGroupBox { get; set; }
  
  public DocumentModel.LayoutContainer? LayoutContainer { get; set; }
  
  public DocumentModel.ImageControl? ImageControl { get; set; }
  
}
