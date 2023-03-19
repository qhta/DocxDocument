namespace DocumentModel.UI;

/// <summary>
///   Defines the ButtonGroup Class.
/// </summary>
public class ButtonGroup: ModelElement
{
  /// <summary>
  ///   id
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public String? IdQ { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public String? GetVisible { get; set; }

  /// <summary>
  ///   insertAfterMso
  /// </summary>
  public String? InsertAfterMso { get; set; }

  /// <summary>
  ///   insertBeforeMso
  /// </summary>
  public String? InsertBeforeMso { get; set; }

  /// <summary>
  ///   insertAfterQ
  /// </summary>
  public String? InsertAfterQ { get; set; }

  /// <summary>
  ///   insertBeforeQ
  /// </summary>
  public String? InsertBeforeQ { get; set; }

  public UnsizedControlClone? UnsizedControlClone { get; set; }

  public UnsizedButton? UnsizedButton { get; set; }

  public UnsizedToggleButton? UnsizedToggleButton { get; set; }

  public UnsizedGallery? UnsizedGallery { get; set; }

  public UnsizedMenu? UnsizedMenu { get; set; }

  public UnsizedDynamicMenu? UnsizedDynamicMenu { get; set; }

  public UnsizedSplitButton? UnsizedSplitButton { get; set; }
}