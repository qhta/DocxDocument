namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HiddenLineProperties Class.
/// </summary>
public class HiddenLineProperties: ModelElement
{
  /// <summary>
  ///   line width
  /// </summary>
  public Int32? Width { get; set; }

  /// <summary>
  ///   line cap
  /// </summary>
  public LineCapKind? CapType { get; set; }

  /// <summary>
  ///   compound line type
  /// </summary>
  public CompoundLineKind? CompoundLineType { get; set; }

  /// <summary>
  ///   pen alignment
  /// </summary>
  public PenAlignmentKind? Alignment { get; set; }

  public Fill? Fill { get; set; }

  public PresetLineDashKind? PresetDash { get; set; }

  public CustomDash? CustomDash { get; set; }

  public bool? Round { get; set; }

  public bool? LineJoinBevel { get; set; }

  public Miter? Miter { get; set; }

  public LineEndPropertiesType? HeadEnd { get; set; }

  public LineEndPropertiesType? TailEnd { get; set; }

  public LinePropertiesExtensionList? LinePropertiesExtensionList { get; set; }
}