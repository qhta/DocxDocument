namespace DocumentModel.Drawings.ChartDrawings;

/// <summary>
///   Defines the GeoCache Class.
/// </summary>
public interface GeoCache: IModelElement
{
  /// <summary>
  ///   provider, this property is only available in Office 2016 and later.
  /// </summary>
  public string? Provider { get; set; }
  public string? Xsdbase64Binary { get; set; }
  public Clear? Clear { get; set; }
}