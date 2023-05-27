namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Underline Stroke.
/// </summary>
public class Underline: ModelElement
{
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