namespace DocumentModel;

/// <summary>
///   Defines the LayoutContainer Class.
/// </summary>
public record LayoutContainer
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }

  /// <summary>
  ///   align, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Align { get; set; }

  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   layoutChildren, this property is only available in Office 2010 and later.
  /// </summary>
  public LayoutChildrenKind? LayoutChildren { get; set; }

  public BackstageGroupButton? BackstageGroupButton { get; set; }

  public BackstageCheckBox? BackstageCheckBox { get; set; }

  public BackstageEditBox? BackstageEditBox { get; set; }

  public BackstageDropDown? BackstageDropDown { get; set; }

  public RadioGroup? RadioGroup { get; set; }

  public BackstageComboBox? BackstageComboBox { get; set; }

  public Hyperlink? Hyperlink { get; set; }

  public BackstageLabelControl? BackstageLabelControl { get; set; }

  public GroupBox? GroupBox { get; set; }

  public LayoutContainer? ChildLayoutContainer { get; set; }

  public ImageControl? ImageControl { get; set; }
}