namespace DocumentModel.Drawings.Diagrams;

/// <summary>
///   Shape.
/// </summary>
[OpenXmlType(typeof(DXDD.Shape))]
[DataContract]
[XmlRoot("Shape", Namespace = "DocumentModel.Drawings.Diagrams")]
public partial class Shape: ModelElement<DXDD.Shape>
{
  /// <summary>
  ///   Rotation
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.Rotation))]
  public Double? Rotation
  {
    get => _Rotation ??= GetProperty<Double?>(GetUpdatableElement()?.Rotation);
    set => UpdateField(ref _Rotation, value, nameof(Rotation));
  }

  private Double? _Rotation;

  /// <summary>
  ///   Shape Type
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.Type))]
  public string? Type
  {
    get => _Type ??= GetProperty<string?>(GetUpdatableElement()?.Type);
    set => UpdateField(ref _Type, value, nameof(Type));
  }

  private string? _Type;

  /// <summary>
  ///   Relationship to Image Part
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.Blip))]
  public string? Blip
  {
    get => _Blip ??= GetProperty<string?>(GetUpdatableElement()?.Blip);
    set => UpdateField(ref _Blip, value, nameof(Blip));
  }

  private string? _Blip;

  /// <summary>
  ///   Z-Order Offset
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.ZOrderOffset))]
  public Int32? ZOrderOffset
  {
    get => _ZOrderOffset ??= GetProperty<Int32?>(GetUpdatableElement()?.ZOrderOffset);
    set => UpdateField(ref _ZOrderOffset, value, nameof(ZOrderOffset));
  }

  private Int32? _ZOrderOffset;

  /// <summary>
  ///   Hide Geometry
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.HideGeometry))]
  public bool? HideGeometry
  {
    get => _HideGeometry ??= GetProperty<bool?>(GetUpdatableElement()?.HideGeometry);
    set => UpdateField(ref _HideGeometry, value, nameof(HideGeometry));
  }

  private bool? _HideGeometry;

  /// <summary>
  ///   Prevent Text Editing
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.LockedText))]
  public bool? LockedText
  {
    get => _LockedText ??= GetProperty<bool?>(GetUpdatableElement()?.LockedText);
    set => UpdateField(ref _LockedText, value, nameof(LockedText));
  }

  private bool? _LockedText;

  /// <summary>
  ///   Image Placeholder
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.BlipPlaceholder))]
  public bool? BlipPlaceholder
  {
    get => _BlipPlaceholder ??= GetProperty<bool?>(GetUpdatableElement()?.BlipPlaceholder);
    set => UpdateField(ref _BlipPlaceholder, value, nameof(BlipPlaceholder));
  }

  private bool? _BlipPlaceholder;

  /// <summary>
  ///   Shape Adjust List.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.AdjustList))]
  public AdjustList? AdjustList
  {
    get => _AdjustList ??= GetProperty<AdjustList?>(GetUpdatableElement()?.AdjustList);
    set => UpdateField(ref _AdjustList, value, nameof(AdjustList));
  }

  private AdjustList? _AdjustList;

  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.Shape.ExtensionList))]
  public IExtensionList? ExtensionList
  {
    get => _ExtensionList ??= GetProperty<IExtensionList?>(GetUpdatableElement()?.ExtensionList);
    set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList));
  }

  private IExtensionList? _ExtensionList;
}