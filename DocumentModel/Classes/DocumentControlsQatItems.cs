namespace DocumentModel;

/// <summary>
///   Defines the DocumentControlsQatItems Class.
/// </summary>
public record DocumentControlsQatItems
{
  public ControlCloneQat? ControlCloneQat { get; set; }

  public ButtonRegular? ButtonRegular { get; set; }

  public Separator? Separator { get; set; }
}