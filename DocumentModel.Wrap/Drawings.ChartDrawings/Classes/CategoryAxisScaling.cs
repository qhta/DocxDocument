namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the CategoryAxisScaling Class.
/// </summary>
public class CategoryAxisScaling: ModelElement
{
  /// <summary>
  ///   gapWidth, this property is only available in Office 2016 and later.
  /// </summary>
  public string? GapWidth { get; set; }
}