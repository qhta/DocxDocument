namespace DocumentModel.Drawings.ChartDrawing;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   IShape Definition.
/// </summary>
public class IShape: ModelElement
{
  /// <summary>
  ///   Reference Ito Custom Function
  /// </summary>
  public string? Macro { get; set; }

  /// <summary>
  ///   Text Link
  /// </summary>
  public string? TextLink { get; set; }

  /// <summary>
  ///   Lock Text
  /// </summary>
  public bool? LockText { get; set; }

  /// <summary>
  ///   Publish Ito Server
  /// </summary>
  public bool? Published { get; set; }

  /// <summary>
  ///   Non-Visual IShape Properties.
  /// </summary>
  public NonVisualShapeProperties? NonVisualShapeProperties { get; set; }

  /// <summary>
  ///   IShape Properties.
  /// </summary>
  public ShapeProperties? ShapeProperties { get; set; }

  /// <summary>
  ///   IShape IStyle.
  /// </summary>
  public IStyle? IStyle { get; set; }

  /// <summary>
  ///   IShape Text Body.
  /// </summary>
  public TextBody? TextBody { get; set; }
}
