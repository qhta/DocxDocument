namespace DocumentModel.UI;

/// <summary>
/// Defines the ButtonGroup Class.
/// </summary>
public partial class ButtonGroup
{
  /// <summary>
  /// id
  /// </summary>
  public String? Id { get; set; }
  
  /// <summary>
  /// idQ
  /// </summary>
  public String? IdQ { get; set; }
  
  /// <summary>
  /// visible
  /// </summary>
  public Boolean? Visible { get; set; }
  
  /// <summary>
  /// getVisible
  /// </summary>
  public String? GetVisible { get; set; }
  
  /// <summary>
  /// insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }
  
  /// <summary>
  /// insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }
  
  /// <summary>
  /// insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }
  
  /// <summary>
  /// insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }
  
  public DocumentModel.UI.UnsizedControlClone? UnsizedControlClone { get; set; }
  
  public DocumentModel.UI.UnsizedButton? UnsizedButton { get; set; }
  
  public DocumentModel.UI.UnsizedToggleButton? UnsizedToggleButton { get; set; }
  
  public DocumentModel.UI.UnsizedGallery? UnsizedGallery { get; set; }
  
  public DocumentModel.UI.UnsizedMenu? UnsizedMenu { get; set; }
  
  public DocumentModel.UI.UnsizedDynamicMenu? UnsizedDynamicMenu { get; set; }
  
  public DocumentModel.UI.UnsizedSplitButton? UnsizedSplitButton { get; set; }
  
}
