namespace DocumentModel.UI;

/// <summary>
///   Defines the SplitButton Class.
/// </summary>
public class SplitButton: ModelElement
{
  /// <summary>
  ///   size
  /// </summary>
  public SizeKind? Size { get; set; }
  /// <summary>
  ///   getSize
  /// </summary>
  public string? GetSize { get; set; }
  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }
  /// <summary>
  ///   getEnabled
  /// </summary>
  public string? GetEnabled { get; set; }
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }
  /// <summary>
  ///   idQ
  /// </summary>
  public string? IdQ { get; set; }
  /// <summary>
  ///   idMso
  /// </summary>
  public string? IdMso { get; set; }
  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }
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
  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }
  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }
  /// <summary>
  ///   keytip
  /// </summary>
  public string? Keytip { get; set; }
  /// <summary>
  ///   getKeytip
  /// </summary>
  public string? GetKeytip { get; set; }
  /// <summary>
  ///   showLabel
  /// </summary>
  public bool? ShowLabel { get; set; }
  /// <summary>
  ///   getShowLabel
  /// </summary>
  public string? GetShowLabel { get; set; }
  public VisibleButton? VisibleButton { get; set; }
  public VisibleToggleButton? VisibleToggleButton { get; set; }
  public UnsizedMenu? UnsizedMenu { get; set; }
}