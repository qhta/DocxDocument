namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Defines the ColorsType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsType))]
public abstract partial class ColorType<T> : ModelElement<T> where T : DXDD.ColorsType
{
  /// <summary>
  ///   Color Application Method Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorsType.Method))]
  public ColorApplicationMethod? Method { get => _Method; set => UpdateField(ref _Method, value, nameof(Method)); }

  private ColorApplicationMethod? _Method;
  /// <summary>
  ///   Hue Direction
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.ColorsType.HueDirection))]
  public HueDirection? HueDirection { get => _HueDirection; set => UpdateField(ref _HueDirection, value, nameof(HueDirection)); }

  private HueDirection? _HueDirection;
}

/// <summary>
///   Defines the ColorsType Class.
/// </summary>
[OpenXmlType(typeof(DXDD.ColorsType))]
public partial class ColorsType: ColorType<DXDD.ColorsType>
{

}