namespace DocumentModel;

/// <summary>
///   Defines the BackstageMenuGroup Class.
/// </summary>
public record BackstageMenuGroup
{
  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Id { get; set; }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public String? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Tag { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }

  /// <summary>
  ///   itemSize, this property is only available in Office 2010 and later.
  /// </summary>
  public ItemSizeKind? ItemSize { get; set; }

  public BackstageMenuButton? BackstageMenuButton { get; set; }

  public BackstageMenuCheckBox? BackstageMenuCheckBox { get; set; }

  public BackstageSubMenu? BackstageSubMenu { get; set; }

  public BackstageMenuToggleButton? BackstageMenuToggleButton { get; set; }
}