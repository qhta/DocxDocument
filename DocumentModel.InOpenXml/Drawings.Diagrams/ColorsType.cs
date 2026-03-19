namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Defines the ColorsType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsType))]
/// <summary>
/// Represents the Colors Type.
/// </summary>
public class ColorsType: ModelElement<DXDD.ColorsType>
{
  /// <summary>
  ///   Color Application Method Type
  /// </summary>
  public ColorApplicationMethod? Method { get; set; }
  /// <summary>
  ///   Hue Direction
  /// </summary>
  public HueDirection? HueDirection { get; set; }
}
