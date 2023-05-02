namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageLabelControl Class.
/// </summary>
public class BackstageLabelControl: ModelElement
{
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
  ///   alignLabel, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? AlignLabel { get; set; }

  /// <summary>
  ///   expand, this property is only available in Office 2010 and later.
  /// </summary>
  public ExpandKind? Expand { get; set; }

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
  ///   noWrap, this property is only available in Office 2010 and later.
  /// </summary>
  public bool? NoWrap { get; set; }
}