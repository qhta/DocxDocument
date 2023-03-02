namespace DocumentModel.UI;

/// <summary>
///   Defines the SharedQatControls Class.
/// </summary>
public record SharedQatControls
{
  public QuickAccessToolbarControlClone? QuickAccessToolbarControlClone { get; set; }

  public UnsizedButton? UnsizedButton { get; set; }

  public VerticalSeparator? VerticalSeparator { get; set; }
}