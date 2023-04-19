namespace DocumentModel.Drawings.Charts;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the PictureOptions Class.
/// </summary>
public class PictureOptions: ModelElement
{
  /// <summary>
  ///   Apply To Front.
  /// </summary>
  public bool? ApplyToFront { get; set; }

  /// <summary>
  ///   Apply To Sides.
  /// </summary>
  public bool? ApplyToSides { get; set; }

  /// <summary>
  ///   Apply to End.
  /// </summary>
  public bool? ApplyToEnd { get; set; }

  /// <summary>
  ///   Picture Format.
  /// </summary>
  public PictureFormatKind? PictureFormat { get; set; }

  /// <summary>
  ///   Picture Stack Unit.
  /// </summary>
  public Double? PictureStackUnit { get; set; }
}