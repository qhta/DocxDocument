namespace DocumentModel.Drawings.SVG;
/// <summary>
///   Defines the SVGBlip Class.
/// </summary>
public partial class SVGBlip : ModelElement<DXO19DS.SVGBlip>
{
  /// <summary>
  ///   Embedded Picture Reference
  /// </summary>
  public string? Embed { get; set; }
  /// <summary>
  ///   Linked Picture Reference
  /// </summary>
  public string? Link { get; set; }
}