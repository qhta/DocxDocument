namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageCheckBox Class.
/// </summary>
public class BackstageCheckBox: ModelElement
{
  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Expand { get; set; }

  /// <summary>
  ///   description, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Description { get; set; }

  /// <summary>
  ///   getDescription, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetDescription { get; set; }

  /// <summary>
  ///   screentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Screentip { get; set; }

  /// <summary>
  ///   getScreentip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetScreentip { get; set; }

  /// <summary>
  ///   supertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Supertip { get; set; }

  /// <summary>
  ///   getSupertip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetSupertip { get; set; }

  /// <summary>
  ///   id, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Id { get; set; }

  /// <summary>
  ///   idQ, this property is only available in Office 2010 and later.
  /// </summary>
  public string? QualifiedId { get; set; }

  /// <summary>
  ///   tag, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Tag { get; set; }

  /// <summary>
  ///   onAction, this property is only available in Office 2010 and later.
  /// </summary>
  public string? OnAction { get; set; }

  /// <summary>
  ///   getPressed, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetPressed { get; set; }

  /// <summary>
  ///   enabled, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Enabled { get; set; }

  /// <summary>
  ///   getEnabled, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetEnabled { get; set; }

  /// <summary>
  ///   label, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Label { get; set; }

  /// <summary>
  ///   getLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetLabel { get; set; }

  /// <summary>
  ///   visible, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? Visible { get; set; }

  /// <summary>
  ///   getVisible, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetVisible { get; set; }

  /// <summary>
  ///   keytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? Keytip { get; set; }

  /// <summary>
  ///   getKeytip, this property is only available in Office 2010 and later.
  /// </summary>
  public string? GetKeytip { get; set; }
}