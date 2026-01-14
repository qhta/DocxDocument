namespace DocumentModel.Drawings;

/// <summary>
/// Represents a container for various drawing effects that can be applied to graphical elements.
/// </summary>
public class EffectList: ModelElement
{
  /// <summary>
  /// Blur effect applied to the element.
  /// </summary>
  public Blur? Blur { get; set; }

  /// <summary>
  /// Fill overlay effect, which overlays a fill on the element.
  /// </summary>
  public FillOverlay? FillOverlay { get; set; }

  /// <summary>
  /// Glow effect, which adds a glowing outline to the element.
  /// </summary>
  public Glow? Glow { get; set; }

  /// <summary>
  /// Inner shadow effect, which adds a shadow inside the boundaries of the element.
  /// </summary>
  public InnerShadow? InnerShadow { get; set; }

  /// <summary>
  /// Outer shadow effect, which adds a shadow outside the boundaries of the element.
  /// </summary>
  public OuterShadow? OuterShadow { get; set; }

  /// <summary>
  /// Preset shadow effect, which applies a predefined shadow style to the element.
  /// </summary>
  public PresetShadow? PresetShadow { get; set; }

  /// <summary>
  /// Reflection effect, which creates a mirrored reflection of the element.
  /// </summary>
  public Reflection? Reflection { get; set; }

  /// <summary>
  /// Soft edge effect, which softens the edges of the element.
  /// </summary>
  public SoftEdge? SoftEdge { get; set; }
}