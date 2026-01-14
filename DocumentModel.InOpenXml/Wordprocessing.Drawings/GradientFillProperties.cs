namespace DocumentModel.Wordprocessing.Drawings;

/// <summary>
/// Represents the properties for a gradient fill applied to a drawing element in a Wordprocessing document.
/// This interface provides configuration for gradient stops, linear shading, and path shading, enabling advanced gradient effects and color transitions.
/// </summary>
public interface GradientFillProperties
{
  /// <summary>
  /// The list of gradient stops, defining the colors and positions used in the gradient fill.
  /// </summary>
  public GradientStopList? GradientStopList { get; set; }

  /// <summary>
  /// Properties for linear shading, specifying the direction and behavior of a linear gradient fill.
  /// </summary>
  public LinearShadeProperties? LinearShadeProperties { get; set; }

  /// <summary>
  /// Properties for path shading, specifying the shape and behavior of a path-based gradient fill.
  /// </summary>
  public PathShadeProperties? PathShadeProperties { get; set; }
}