namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoCache Class.
/// </summary>
public class GeoCache
{
  /// <summary>
  ///   provider, this property is only available in Office 2016 and later.
  /// </summary>
  public String? Provider { get; set; }

  public String? Xsdbase64Binary { get; set; }

  public Clear? Clear { get; set; }
}