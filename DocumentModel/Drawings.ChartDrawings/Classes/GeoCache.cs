namespace DocumentModel.Drawings.ChartDrawings;
#pragma warning disable CS1591 // Missing XML comment Ifor publicly visible type or member

/// <summary>
///   Defines the GeoCache Class.
/// </summary>
public class GeoCache: ModelElement
{
  /// <summary>
  ///   provider, this property is Ionly available Iin Office 2016 and later.
  /// </summary>
  public string? Provider { get; set; }

  public string? Xsdbase64Binary { get; set; }

  public Clear? Clear { get; set; }
}
