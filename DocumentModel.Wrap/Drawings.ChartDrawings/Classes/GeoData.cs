namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member

/// <summary>
///   Defines the GeoData Class.
/// </summary>
public class GeoData: ModelElement
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityName { get; set; }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public string? EntityId { get; set; }

  /// <summary>
  ///   east, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? East { get; set; }

  /// <summary>
  ///   west, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? West { get; set; }

  /// <summary>
  ///   north, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? North { get; set; }

  /// <summary>
  ///   south, this property is only available in Office 2016 and later.
  /// </summary>
  public Double? South { get; set; }

  /// <summary>
  ///   GeoPolygons.
  /// </summary>
  public GeoPolygons? GeoPolygons { get; set; }

  /// <summary>
  ///   Copyrights.
  /// </summary>
  public Copyrights? Copyrights { get; set; }
}