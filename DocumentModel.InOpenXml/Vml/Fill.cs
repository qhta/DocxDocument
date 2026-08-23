namespace DocumentModel.Vml;

/// <summary>
///   Defines the fill properties of a shape.
/// </summary>
[OpenXmlType(typeof(DXV.Fill))]
[DataContract]
[XmlRoot("Fill", Namespace = "DocumentModel.Vml")]
public partial class Fill: ModelElement<DXV.Fill>
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Fill Type
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Type))]
  public FillType? Type
  {
    get => _Type ??= GetProperty<FillType?>(GetUpdatableElement()?.Type);
    set => UpdateField(ref _Type, value, nameof(Type));
  }

  private FillType? _Type;

  /// <summary>
  ///   Fill Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.On))]
  public bool? On
  {
    get => _On ??= GetProperty<bool?>(GetUpdatableElement()?.On);
    set => UpdateField(ref _On, value, nameof(On));
  }

  private bool? _On;

  /// <summary>
  ///   Primary Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Color))]
  public DMV.VmlColor? Color
  {
    get => _Color ??= GetProperty<DMV.VmlColor?>(GetUpdatableElement()?.Color);
    set => UpdateField(ref _Color, value, nameof(Color));
  }

  private DMV.VmlColor? _Color;

  /// <summary>
  ///   Primary Color Opacity
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Opacity))]
  public string? Opacity
  {
    get => _Opacity ??= GetProperty<string?>(GetUpdatableElement()?.Opacity);
    set => UpdateField(ref _Opacity, value, nameof(Opacity));
  }

  private string? _Opacity;

  /// <summary>
  ///   Secondary Color
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Color2))]
  public string? Color2
  {
    get => _Color2 ??= GetProperty<string?>(GetUpdatableElement()?.Color2);
    set => UpdateField(ref _Color2, value, nameof(Color2));
  }

  private string? _Color2;

  /// <summary>
  ///   Fill Image Source
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Source))]
  public string? Source
  {
    get => _Source ??= GetProperty<string?>(GetUpdatableElement()?.Source);
    set => UpdateField(ref _Source, value, nameof(Source));
  }

  private string? _Source;

  /// <summary>
  ///   IHyperlink Target
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Href))]
  public string? Href
  {
    get => _Href ??= GetProperty<string?>(GetUpdatableElement()?.Href);
    set => UpdateField(ref _Href, value, nameof(Href));
  }

  private string? _Href;

  /// <summary>
  ///   Alternate Image Reference Location
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.AlternateImageReference))]
  public string? AlternateImageReference
  {
    get => _AlternateImageReference ??= GetProperty<string?>(GetUpdatableElement()?.AlternateImageReference);
    set => UpdateField(ref _AlternateImageReference, value, nameof(AlternateImageReference));
  }

  private string? _AlternateImageReference;

  /// <summary>
  ///   Fill Image Size
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Size))]
  public string? Size
  {
    get => _Size ??= GetProperty<string?>(GetUpdatableElement()?.Size);
    set => UpdateField(ref _Size, value, nameof(Size));
  }

  private string? _Size;

  /// <summary>
  ///   Fill Image Origin
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Origin))]
  public string? Origin
  {
    get => _Origin ??= GetProperty<string?>(GetUpdatableElement()?.Origin);
    set => UpdateField(ref _Origin, value, nameof(Origin));
  }

  private string? _Origin;

  /// <summary>
  ///   Fill Image Position
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Position))]
  public string? Position
  {
    get => _Position ??= GetProperty<string?>(GetUpdatableElement()?.Position);
    set => UpdateField(ref _Position, value, nameof(Position));
  }

  private string? _Position;

  /// <summary>
  ///   Image Aspect Ratio
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Aspect))]
  public ImageAspectType? Aspect
  {
    get => _Aspect ??= GetProperty<ImageAspectType?>(GetUpdatableElement()?.Aspect);
    set => UpdateField(ref _Aspect, value, nameof(Aspect));
  }

  private ImageAspectType? _Aspect;

  /// <summary>
  ///   Intermediate Colors
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Colors))]
  public string? Colors
  {
    get => _Colors ??= GetProperty<string?>(GetUpdatableElement()?.Colors);
    set => UpdateField(ref _Colors, value, nameof(Colors));
  }

  private string? _Colors;

  /// <summary>
  ///   Gradient Angle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Angle))]
  public Decimal? Angle
  {
    get => _Angle ??= GetProperty<Decimal?>(GetUpdatableElement()?.Angle);
    set => UpdateField(ref _Angle, value, nameof(Angle));
  }

  private Decimal? _Angle;

  /// <summary>
  ///   Align Image With Shape
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.AlignShape))]
  public bool? AlignShape
  {
    get => _AlignShape ??= GetProperty<bool?>(GetUpdatableElement()?.AlignShape);
    set => UpdateField(ref _AlignShape, value, nameof(AlignShape));
  }

  private bool? _AlignShape;

  /// <summary>
  ///   Gradient Center
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Focus))]
  public string? Focus
  {
    get => _Focus ??= GetProperty<string?>(GetUpdatableElement()?.Focus);
    set => UpdateField(ref _Focus, value, nameof(Focus));
  }

  private string? _Focus;

  /// <summary>
  ///   Radial Gradient Size
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.FocusSize))]
  public string? FocusSize
  {
    get => _FocusSize ??= GetProperty<string?>(GetUpdatableElement()?.FocusSize);
    set => UpdateField(ref _FocusSize, value, nameof(FocusSize));
  }

  private string? _FocusSize;

  /// <summary>
  ///   Radial Gradient Center
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.FocusPosition))]
  public string? FocusPosition
  {
    get => _FocusPosition ??= GetProperty<string?>(GetUpdatableElement()?.FocusPosition);
    set => UpdateField(ref _FocusPosition, value, nameof(FocusPosition));
  }

  private string? _FocusPosition;

  /// <summary>
  ///   Gradient Fill Method
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Method))]
  public FillMethod? Method
  {
    get => _Method ??= GetProperty<FillMethod?>(GetUpdatableElement()?.Method);
    set => UpdateField(ref _Method, value, nameof(Method));
  }

  private FillMethod? _Method;

  /// <summary>
  ///   Detect Mouse Click
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.DetectMouseClick))]
  public bool? DetectMouseClick
  {
    get => _DetectMouseClick ??= GetProperty<bool?>(GetUpdatableElement()?.DetectMouseClick);
    set => UpdateField(ref _DetectMouseClick, value, nameof(DetectMouseClick));
  }

  private bool? _DetectMouseClick;

  /// <summary>
  ///   Title
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Title))]
  public string? Title
  {
    get => _Title ??= GetProperty<string?>(GetUpdatableElement()?.Title);
    set => UpdateField(ref _Title, value, nameof(Title));
  }

  private string? _Title;

  /// <summary>
  ///   Secondary Color Opacity
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Opacity2))]
  public string? Opacity2
  {
    get => _Opacity2 ??= GetProperty<string?>(GetUpdatableElement()?.Opacity2);
    set => UpdateField(ref _Opacity2, value, nameof(Opacity2));
  }

  private string? _Opacity2;

  /// <summary>
  ///   Recolor Fill as Picture
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Recolor))]
  public bool? Recolor
  {
    get => _Recolor ??= GetProperty<bool?>(GetUpdatableElement()?.Recolor);
    set => UpdateField(ref _Recolor, value, nameof(Recolor));
  }

  private bool? _Recolor;

  /// <summary>
  ///   Rotate Fill with Shape
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.Rotate))]
  public bool? Rotate
  {
    get => _Rotate ??= GetProperty<bool?>(GetUpdatableElement()?.Rotate);
    set => UpdateField(ref _Rotate, value, nameof(Rotate));
  }

  private bool? _Rotate;

  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.RelationshipId))]
  public string? RelationshipId
  {
    get => _RelationshipId ??= GetProperty<string?>(GetUpdatableElement()?.RelationshipId);
    set => UpdateField(ref _RelationshipId, value, nameof(RelationshipId));
  }

  private string? _RelationshipId;

  /// <summary>
  ///   FillExtendedProperties.
  /// </summary>
  [OpenXmlProperty(nameof(DXV.Fill.FillExtendedProperties))]
  public FillExtendedProperties? FillExtendedProperties
  {
    get => _FillExtendedProperties ??=
      GetProperty<FillExtendedProperties?>(GetUpdatableElement()?.FillExtendedProperties);
    set => UpdateField(ref _FillExtendedProperties, value, nameof(FillExtendedProperties));
  }

  private FillExtendedProperties? _FillExtendedProperties;
}