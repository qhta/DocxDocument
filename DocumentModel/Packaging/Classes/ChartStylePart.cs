using DocumentModel.Drawings.ChartsStyle;

namespace DocumentModel.Packaging;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the ChartStylePart
/// </summary>
public class ChartStylePart: ModelElement
{
  /// <summary>
  ///   Gets or sets the root element of this part.
  /// </summary>
  public ChartStyle? ChartStyle { get; set; }

  public string? ContentType { get; set; }

  public string? RelationshipType { get; set; }
}