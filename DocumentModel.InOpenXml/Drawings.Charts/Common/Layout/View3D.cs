namespace DocumentModel.Drawings.Charts;

/// <summary>
///   3D view settings.
/// </summary>
[OpenXmlType(typeof(DXDC.View3D))]
[DataContract]
[XmlRoot("View3D", Namespace = "DocumentModel.Drawings.Charts")]
public partial class View3D: ModelElement<DXDC.View3D>
{
  /// <summary>
  ///   X Rotation.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.RotateX))]
  public SByte? RotateX
  {
    get => _RotateX ??= GetProperty<SByte?>(GetUpdatableElement()?.RotateX);
    set => UpdateField(ref _RotateX, value, nameof(RotateX));
  }

  private SByte? _RotateX;

  /// <summary>
  ///   Height Percent.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.HeightPercent))]
  public UInt16? HeightPercent
  {
    get => _HeightPercent ??= GetProperty<UInt16?>(GetUpdatableElement()?.HeightPercent);
    set => UpdateField(ref _HeightPercent, value, nameof(HeightPercent));
  }

  private UInt16? _HeightPercent;

  /// <summary>
  ///   Y Rotation.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.RotateY))]
  public UInt16? RotateY
  {
    get => _RotateY ??= GetProperty<UInt16?>(GetUpdatableElement()?.RotateY);
    set => UpdateField(ref _RotateY, value, nameof(RotateY));
  }

  private UInt16? _RotateY;

  /// <summary>
  ///   Depth Percent.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.DepthPercent))]
  public UInt16? DepthPercent
  {
    get => _DepthPercent ??= GetProperty<UInt16?>(GetUpdatableElement()?.DepthPercent);
    set => UpdateField(ref _DepthPercent, value, nameof(DepthPercent));
  }

  private UInt16? _DepthPercent;

  /// <summary>
  ///   Right Angle Axes.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.RightAngleAxes))]
  public bool? RightAngleAxes
  {
    get => _RightAngleAxes ??= GetProperty<bool?>(GetUpdatableElement()?.RightAngleAxes);
    set => UpdateField(ref _RightAngleAxes, value, nameof(RightAngleAxes));
  }

  private bool? _RightAngleAxes;

  /// <summary>
  ///   Perspective.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.Perspective))]
  public Byte? Perspective
  {
    get => _Perspective ??= GetProperty<Byte?>(GetUpdatableElement()?.Perspective);
    set => UpdateField(ref _Perspective, value, nameof(Perspective));
  }

  private Byte? _Perspective;

  /// <summary>
  ///   Chart Extensibility.
  /// </summary>
  [OpenXmlProperty(nameof(DXDC.View3D.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}