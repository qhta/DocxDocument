namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the BackstageLabelControl Class.
/// </summary>
public interface BackstageLabelControl
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
  ///   noWrap
  /// </summary>
  public bool? NoWrap { get; set; }
}