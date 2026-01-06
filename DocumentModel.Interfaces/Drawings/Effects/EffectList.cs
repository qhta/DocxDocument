namespace DocumentModel.Drawings;

/// <summary>
/// Represents a container for various drawing effects that can be applied to graphical elements.
/// </summary>
public interface EffectList
{
  /// <summary>
  /// Gets or sets the blur effect applied to the element.
  /// </summary>
  public Blur? Blur { get; set; }

  /// <summary>
  /// Gets or sets the fill overlay effect, which overlays a fill on the element.
  /// </summary>
  public FillOverlay? FillOverlay { get; set; }

  /// <summary>
  /// Gets or sets the glow effect, which adds a glowing outline to the element.
  /// </summary>
  public Glow? Glow { get; set; }

  /// <summary>
  /// Gets or sets the inner shadow effect, which adds a shadow inside the boundaries of the element.
  /// </summary>
  public InnerShadow? InnerShadow { get; set; }

  /// <summary>
  /// Gets or sets the outer shadow effect, which adds a shadow outside the boundaries of the element.
  /// </summary>
  public OuterShadow? OuterShadow { get; set; }

  /// <summary>
  /// Gets or sets the preset shadow effect, which applies a predefined shadow style to the element.
  /// </summary>
  public PresetShadow? PresetShadow { get; set; }

  /// <summary>
  /// Gets or sets the reflection effect, which creates a mirrored reflection of the element.
  /// </summary>
  public Reflection? Reflection { get; set; }

  /// <summary>
  /// Gets or sets the soft edge effect, which softens the edges of the element.
  /// </summary>
  public SoftEdge? SoftEdge { get; set; }
}