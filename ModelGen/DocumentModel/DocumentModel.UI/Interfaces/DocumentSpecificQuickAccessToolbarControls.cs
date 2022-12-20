namespace DocumentModel.UI;

/// <summary>
/// Defines the DocumentSpecificQuickAccessToolbarControls Class.
/// </summary>
public partial interface DocumentSpecificQuickAccessToolbarControls
{
  public DocumentModel.UI.QuickAccessToolbarControlClone? QuickAccessToolbarControlClone { get; set; }
  
  public DocumentModel.UI.UnsizedButton? UnsizedButton { get; set; }
  
  public DocumentModel.UI.VerticalSeparator? VerticalSeparator { get; set; }
  
}
