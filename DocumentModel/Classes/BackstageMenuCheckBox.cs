namespace DocumentModel;

/// <summary>
///   Defines the BackstageMenuCheckBox Class.
/// </summary>
public record BackstageMenuCheckBox
{
  /// <summary>
  ///   description, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Description { get; set; }

  /// <summary>
  ///   getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetDescription { get; set; }

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
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public String? OnAction { get; set; }

  /// <summary>
  ///   getPressed, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetPressed { get; set; }

  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Enabled { get; set; }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetEnabled { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetLabel { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public Boolean? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetVisible { get; set; }

  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Keytip { get; set; }

  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public String? GetKeytip { get; set; }
}