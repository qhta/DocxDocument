namespace DocumentModel.Vml;

/// <summary>
///   Defines the Shadow Class.
/// </summary>
[OpenXmlType(typeof(DXV.Shadow))]
[DataContract]
[XmlRoot("Shadow", Namespace = "DocumentModel.Vml")]
public partial class Shadow: ModelElement<DXV.Shadow>
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Shadow Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.On))]
  public bool? On
  {
    get => _On ??= GetProperty<bool?>(GetUpdatableElement()?.On);
    set => UpdateField(ref _On, value, nameof(On));
  }

  private bool? _On;

  /// <summary>
  ///   Shadow Type
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Type))]
  public ShadowType? Type
  {
    get => _Type ??= GetProperty<ShadowType?>(GetUpdatableElement()?.Type);
    set => UpdateField(ref _Type, value, nameof(Type));
  }

  private ShadowType? _Type;

  /// <summary>
  ///   Shadow Transparency
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Obscured))]
  public bool? Obscured
  {
    get => _Obscured ??= GetProperty<bool?>(GetUpdatableElement()?.Obscured);
    set => UpdateField(ref _Obscured, value, nameof(Obscured));
  }

  private bool? _Obscured;

  /// <summary>
  ///   Shadow Primary Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Color))]
  public VmlColor? Color
  {
    get => _Color ??= GetProperty<VmlColor?>(GetUpdatableElement()?.Color);
    set => UpdateField(ref _Color, value, nameof(Color));
  }

  private VmlColor? _Color;

  /// <summary>
  ///   Shadow Opacity
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Opacity))]
  public string? Opacity
  {
    get => _Opacity ??= GetProperty<string?>(GetUpdatableElement()?.Opacity);
    set => UpdateField(ref _Opacity, value, nameof(Opacity));
  }

  private string? _Opacity;

  /// <summary>
  ///   Shadow Primary Offset
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Offset))]
  public string? Offset
  {
    get => _Offset ??= GetProperty<string?>(GetUpdatableElement()?.Offset);
    set => UpdateField(ref _Offset, value, nameof(Offset));
  }

  private string? _Offset;

  /// <summary>
  ///   Shadow Secondary Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Color2))]
  public VmlColor? Color2
  {
    get => _Color2 ??= GetProperty<VmlColor?>(GetUpdatableElement()?.Color2);
    set => UpdateField(ref _Color2, value, nameof(Color2));
  }

  private VmlColor? _Color2;

  /// <summary>
  ///   Shadow Secondary Offset
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Offset2))]
  public string? Offset2
  {
    get => _Offset2 ??= GetProperty<string?>(GetUpdatableElement()?.Offset2);
    set => UpdateField(ref _Offset2, value, nameof(Offset2));
  }

  private string? _Offset2;

  /// <summary>
  ///   Shadow Origin
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Origin))]
  public string? Origin
  {
    get => _Origin ??= GetProperty<string?>(GetUpdatableElement()?.Origin);
    set => UpdateField(ref _Origin, value, nameof(Origin));
  }

  private string? _Origin;

  /// <summary>
  ///   Shadow Perspective Matrix
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Shadow.Matrix))]
  public string? Matrix
  {
    get => _Matrix ??= GetProperty<string?>(GetUpdatableElement()?.Matrix);
    set => UpdateField(ref _Matrix, value, nameof(Matrix));
  }

  private string? _Matrix;
}