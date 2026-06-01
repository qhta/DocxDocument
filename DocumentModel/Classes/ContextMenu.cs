namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the ContextMenu Class.
/// </summary>
public class ContextMenu: ModelElement
{
  /// <summary>
  ///   idMso, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? IdMso { get; set; }

  public ControlCloneRegular? ControlCloneRegular { get; set; }

  public ButtonRegular? ButtonRegular { get; set; }

  public ICheckBox? ICheckBox { get; set; }

  public GalleryRegular? GalleryRegular { get; set; }

  public ToggleButtonRegular? ToggleButtonRegular { get; set; }

  public SplitButtonRegular? SplitButtonRegular { get; set; }

  public MenuRegular? MenuRegular { get; set; }

  public DynamicMenuRegular? DynamicMenuRegular { get; set; }

  public MenuSeparatorNoTitle? MenuSeparatorNoTitle { get; set; }
}
