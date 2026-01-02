namespace DocumentModel;

/// <summary>
///   Defines the GroupBox Class.
/// </summary>
public class GroupBox: ModelElement
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }
  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Expand { get; set; }
  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }
  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }
  public BackstageGroupButton? BackstageGroupButton { get; set; }
  public BackstageCheckBox? BackstageCheckBox { get; set; }
  public BackstageEditBox? BackstageEditBox { get; set; }
  public BackstageDropDown? BackstageDropDown { get; set; }
  public RadioGroup? RadioGroup { get; set; }
  public BackstageComboBox? BackstageComboBox { get; set; }
  public Hyperlink? Hyperlink { get; set; }
  public BackstageLabelControl? BackstageLabelControl { get; set; }
  public GroupBox? ChildGroupBox { get; set; }
  public LayoutContainer? LayoutContainer { get; set; }
  public ImageControl? ImageControl { get; set; }
}