namespace DocumentModel;

/// <summary>
/// Defines the SharedControlsQatItems Class.
/// </summary>
public partial interface SharedControlsQatItems
{
  public DocumentModel.ControlCloneQat? ControlCloneQat { get; set; }
  
  public DocumentModel.ButtonRegular? ButtonRegular { get; set; }
  
  public DocumentModel.Separator? Separator { get; set; }
  
}
