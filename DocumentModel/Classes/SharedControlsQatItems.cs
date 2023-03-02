namespace DocumentModel;

/// <summary>
///   Defines the SharedControlsQatItems Class.
/// </summary>
public record SharedControlsQatItems
{
  public ControlCloneQat? ControlCloneQat { get; set; }

  public ButtonRegular? ButtonRegular { get; set; }

  public Separator? Separator { get; set; }
}