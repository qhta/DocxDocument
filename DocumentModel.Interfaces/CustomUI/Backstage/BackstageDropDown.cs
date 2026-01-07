namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageDropDown Class.
/// </summary>
public interface BackstageDropDown
{
  /// <summary>
  ///   id
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   alignLabel
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  ///   expand
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   enabled
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   label
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   visible
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   onAction
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  ///   screentip
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   getScreentip
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   supertip
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   getSupertip
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   keytip
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip
  /// </summary>
  public string? GetKeytip { get; set; }

  /// <summary>
  ///   getSelectedItemIndex
  /// </summary>
  public string? GetSelectedItemIndex { get; set; }

  /// <summary>
  ///   sizeString
  /// </summary>
  public string? SizeString { get; set; }

  /// <summary>
  ///   getItemCount
  /// </summary>
  public string? GetItemCount { get; set; }

  /// <summary>
  ///   getItemLabel
  /// </summary>
  public string? GetItemLabel { get; set; }

  /// <summary>
  ///   getItemID
  /// </summary>
  public string? GetItemID { get; set; }

  public BackstageItems? BackstageItems { get; set; }
}