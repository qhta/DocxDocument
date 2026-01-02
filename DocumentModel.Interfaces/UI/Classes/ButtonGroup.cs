namespace DocumentModel.UI;

/// <summary>
///   Defines the ButtonGroup Class.
/// </summary>
public class ButtonGroup: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ
  /// </summary>
  public string? IdQ { get; set; }
  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }
  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public string? InsertAfterMso { get; set; }
  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public string? InsertBeforeMso { get; set; }
  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public string? InsertAfterQ { get; set; }
  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public string? InsertBeforeQ { get; set; }
  public UnsizedControlClone? UnsizedControlClone { get; set; }
  public UnsizedButton? UnsizedButton { get; set; }
  public UnsizedToggleButton? UnsizedToggleButton { get; set; }
  public UnsizedGallery? UnsizedGallery { get; set; }
  public UnsizedMenu? UnsizedMenu { get; set; }
  public UnsizedDynamicMenu? UnsizedDynamicMenu { get; set; }
  public UnsizedSplitButton? UnsizedSplitButton { get; set; }
}