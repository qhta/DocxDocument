namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public class DocumentSpecificQuickAccessToolbarControls: ModelElement
{
  public QuickAccessToolbarControlClone? QuickAccessToolbarControlClone { get; set; }

  public UnsizedButton? UnsizedButton { get; set; }

  public VerticalSeparator? VerticalSeparator { get; set; }
}
