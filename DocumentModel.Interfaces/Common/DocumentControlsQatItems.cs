namespace DocumentModel;

/// <summary>
///   Defines the DocumentControlsQatItems Class.
/// </summary>
public interface DocumentControlsQatItems: IModelElement
{
  public ControlCloneQat? ControlCloneQat { get; set; }
  public ButtonRegular? ButtonRegular { get; set; }
  public Separator? Separator { get; set; }
}