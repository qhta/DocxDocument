namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the DocumentControlsQatItems Class.
/// </summary>
public class DocumentControlsQatItems: ModelElement
{
  public ControlCloneQat? ControlCloneQat { get; set; }

  public ButtonRegular? ButtonRegular { get; set; }

  public Separator? Separator { get; set; }
}