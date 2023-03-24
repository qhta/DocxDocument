namespace DocumentModel.UI;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the SharedQatControls Class.
/// </summary>
public class SharedQatControls: ModelElement
{
  public QuickAccessToolbarControlClone? QuickAccessToolbarControlClone { get; set; }

  public UnsizedButton? UnsizedButton { get; set; }

  public VerticalSeparator? VerticalSeparator { get; set; }
}