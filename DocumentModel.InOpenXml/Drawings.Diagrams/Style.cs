namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape Style.
/// </summary>
[OpenXmlType(typeof(DXDD.Style))]
public class Style: ModelElement<DXDD.Style>
{
  /// <summary>
  ///   LineReference.
  /// </summary>
  public LineReference? LineReference { get; set; }
  /// <summary>
  ///   FillReference.
  /// </summary>
  public FillReference? FillReference { get; set; }
  /// <summary>
  ///   EffectReference.
  /// </summary>
  public EffectReference? EffectReference { get; set; }
  /// <summary>
  ///   Font Reference.
  /// </summary>
  public FontReference? FontReference { get; set; }
}