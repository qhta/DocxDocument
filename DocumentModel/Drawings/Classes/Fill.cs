namespace DocumentModel.Drawings;

/// <summary>
///   Fill.
/// </summary>
public class Fill: ModelElement
{
  /// <summary>
  ///   NoFill.
  /// </summary>
  public Boolean? NoFill { get; set; }

  /// <summary>
  ///   SolidFill.
  /// </summary>
  public SolidFill? SolidFill { get; set; }

  /// <summary>
  ///   GradientFill.
  /// </summary>
  public GradientFill? GradientFill { get; set; }

  /// <summary>
  ///   BlipFill.
  /// </summary>
  public BlipFill? BlipFill { get; set; }

  /// <summary>
  ///   Pattern Fill.
  /// </summary>
  public PatternFill? PatternFill { get; set; }

  /// <summary>
  ///   Group Fill.
  /// </summary>
  public Boolean? GroupFill { get; set; }
}