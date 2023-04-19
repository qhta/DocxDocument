namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoCache Class.
/// </summary>
public class GeoCache: ModelElement
{
  /// <summary>
  ///   provider, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Provider { get; set; }

  public string? Xsdbase64Binary { get; set; }

  public Clear? Clear { get; set; }
}