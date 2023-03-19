namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoData Class.
/// </summary>
public class GeoData: ModelElement
{
  /// <summary>
  ///   entityName, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityName { get; set; }

  /// <summary>
  ///   entityId, this property is only available in Office 2016 and later.
  /// </summary>
  public String? EntityId { get; set; }

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