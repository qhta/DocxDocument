namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BottomItemsGroupControls Class.
/// </summary>
public class BottomItemsGroupControls: ModelElement
{
  public BackstageGroupButton? BackstageGroupButton { get; set; }

  public BackstageCheckBox? BackstageCheckBox { get; set; }

  public BackstageEditBox? BackstageEditBox { get; set; }

  public BackstageDropDown? BackstageDropDown { get; set; }

  public RadioGroup? RadioGroup { get; set; }

  public BackstageComboBox? BackstageComboBox { get; set; }

  public Hyperlink? Hyperlink { get; set; }

  public BackstageLabelControl? BackstageLabelControl { get; set; }

  public GroupBox? GroupBox { get; set; }

  public LayoutContainer? LayoutContainer { get; set; }

  public ImageControl? ImageControl { get; set; }
}