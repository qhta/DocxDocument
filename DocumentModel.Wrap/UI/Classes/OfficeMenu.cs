namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the OfficeMenu Class.
/// </summary>
public class OfficeMenu: ModelElement
{
  public UnsizedControlClone? UnsizedControlClone { get; set; }

  public UnsizedButton? UnsizedButton { get; set; }

  public CheckBox? CheckBox { get; set; }

  public UnsizedGallery? UnsizedGallery { get; set; }

  public UnsizedToggleButton? UnsizedToggleButton { get; set; }

  public MenuSeparator? MenuSeparator { get; set; }

  public SplitButtonWithTitle? SplitButtonWithTitle { get; set; }

  public MenuWithTitle? MenuWithTitle { get; set; }

  public UnsizedDynamicMenu? UnsizedDynamicMenu { get; set; }
}