namespace DocumentModel.Drawings;

/// <summary>
///   Represents a saturation effect, allowing adjustment of color saturation for a drawing element.
/// </summary>
public class Saturation: ModelElement
{
  /// <summary>
  ///   Amount of saturation adjustment.
  /// </summary>
  public Int32? SaturationAmount { get; set; }
}