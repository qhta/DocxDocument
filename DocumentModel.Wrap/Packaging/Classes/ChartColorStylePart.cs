using DocumentModel.Drawings.ChartsStyle;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartColorStylePart
/// </summary>
public class ChartColorStylePart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ColorStyle? ColorStyle { get; set; }

  public string? ContentType { get; set; }

  public string? RelationshipType { get; set; }
}