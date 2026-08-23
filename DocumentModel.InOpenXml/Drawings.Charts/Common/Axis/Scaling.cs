namespace DocumentModel.Drawings.Charts;

/// <summary>
///   Scaling.
/// </summary>
[OpenXmlType(typeof(DXDC.Scaling))]
[DataContract]
[XmlRoot("Scaling", Namespace = "DocumentModel.Drawings.Charts")]
public partial class Scaling: ModelElement<DXDC.Scaling>
{
  /// <summary>
  ///   Logarithmic Base.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.LogBase))]
  public Double? LogBase
  {
    get => _LogBase ??= GetElement<Double, DXDC.LogBase>(GetUpdatableElement());
    set => UpdateField(ref _LogBase, value, nameof(LogBase));
  }

  private Double? _LogBase;

  /// <summary>
  ///   Axis Orientation.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.Orientation))]
  public Orientation? Orientation
  {
    get => _Orientation ??= GetElement<Orientation, DXDC.Orientation>(GetUpdatableElement());
    set => UpdateField(ref _Orientation, value, nameof(Orientation));
  }

  private Orientation? _Orientation;

  /// <summary>
  ///   Maximum.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.MaxAxisValue))]
  public Double? MaxAxisValue
  {
    get => _MaxAxisValue ??= GetElement<Double, DXDC.MaxAxisValue>(GetUpdatableElement());
    set => UpdateField(ref _MaxAxisValue, value, nameof(MaxAxisValue));
  }

  private Double? _MaxAxisValue;

  /// <summary>
  ///   Minimum.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.MinAxisValue))]
  public Double? MinAxisValue
  {
    get => _MinAxisValue ??= GetElement<Double, DXDC.MinAxisValue>(GetUpdatableElement());
    set => UpdateField(ref _MinAxisValue, value, nameof(MinAxisValue));
  }

  private Double? _MinAxisValue;

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlElement(typeof(DXDC.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetElement<IExtensionList, DXDC.ExtensionList>(GetUpdatableElement());
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}