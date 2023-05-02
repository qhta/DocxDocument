namespace DocumentModel.Drawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the HiddenFillProperties Class.
/// </summary>
public class HiddenFillProperties: ModelElement
{
  /// <summary>
  ///   NoFill.
  /// </summary>
  public bool? NoFill { get; set; }

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
  public bool? GroupFill { get; set; }
}