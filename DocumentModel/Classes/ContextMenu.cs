namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ContextMenu Class.
/// </summary>
public class ContextMenu: ModelElement
{
  /// <summary>
  ///   idMso, this property is only available in Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }

  public ControlCloneRegular? ControlCloneRegular { get; set; }

  public ButtonRegular? ButtonRegular { get; set; }

  public CheckBox? CheckBox { get; set; }

  public GalleryRegular? GalleryRegular { get; set; }

  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  public SplitButtonRegular? SplitButtonRegular { get; set; }

  public MenuRegular? MenuRegular { get; set; }

  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  public MenuSeparatorNoTitle? MenuSeparatorNoTitle { get; set; }
}