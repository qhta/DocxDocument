namespace DocumentModel.Drawings.Charts;
/// <summary>
///   Scaling.
/// </summary>
[OpenXmlType(typeof(DXDC.Scaling))]
public partial class Scaling: ModelElement<DXDC.Scaling>
{
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.LogBase))]
  public Double? LogBase { get => _LogBase; set => UpdateField(ref _LogBase, value, nameof(LogBase)); }
  private Double? _LogBase;
  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Orientation))]
  public Orientation? Orientation
  {
    get => _Orientation;
    set => UpdateField(ref _Orientation, value, nameof(Orientation));
  }
  private Orientation? _Orientation;
  /// <summary>
  ///   Maximum.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.MaxAxisValue))]
  public Double? MaxAxisValue
  {
    get => _MaxAxisValue;
    set => UpdateField(ref _MaxAxisValue, value, nameof(MaxAxisValue));
  }
  private Double? _MaxAxisValue;
  /// <summary>
  ///   Minimum.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.MinAxisValue))]
  public Double? MinAxisValue
  {
    get => _MinAxisValue;
    set => UpdateField(ref _MinAxisValue, value, nameof(MinAxisValue));
  }
  private Double? _MinAxisValue;
  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public ExtensionList? ExtensionList
  {
    get => _ExtensionList;
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }
  private ExtensionList? _ExtensionList;
}