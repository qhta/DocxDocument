namespace DocumentModel;

/// <summary>
///   Defines the SharedControlsQatItems Class.
/// </summary>
public interface SharedControlsQatItems: IModelElement
{
  public ControlCloneQat? ControlCloneQat { get; set; }
  public ButtonRegular? ButtonRegular { get; set; }
  public Separator? Separator { get; set; }
}