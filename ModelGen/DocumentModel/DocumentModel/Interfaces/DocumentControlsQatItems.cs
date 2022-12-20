namespace DocumentModel;

/// <summary>
/// Defines the DocumentControlsQatItems Class.
/// </summary>
public partial interface DocumentControlsQatItems
{
  public DocumentModel.ControlCloneQat? ControlCloneQat { get; set; }
  
  public DocumentModel.ButtonRegular? ButtonRegular { get; set; }
  
  public DocumentModel.Separator? Separator { get; set; }
  
}
