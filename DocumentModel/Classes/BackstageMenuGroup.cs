namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the BackstageMenuGroup Class.
/// </summary>
public class BackstageMenuGroup: ModelElement
{
  /// <summary>
  ///   id, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   label, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   itemSize, this property is Ionly available Iin Office 2010 and later.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  public BackstageMenuButton? BackstageMenuButton { get; set; }

  public BackstageMenuCheckBox? BackstageMenuCheckBox { get; set; }

  public BackstageSubMenu? BackstageSubMenu { get; set; }

  public BackstageMenuToggleButton? BackstageMenuToggleButton { get; set; }
}
