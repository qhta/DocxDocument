namespace DocumentModel.Drawings;
/// <summary>
/// Represents an alpha inset or outset effect, which modifies the transparency of an image or shape based on a specified radius.
/// </summary>
public partial class AlphaOutset : ModelElement<DXD.AlphaOutset>
{
  /// <summary>
  /// Radius value that determines the extent of the alpha inset or outset effect.
  /// </summary>
  public Int64? Radius { get; set; }
}