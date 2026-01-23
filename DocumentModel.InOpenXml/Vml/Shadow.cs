namespace DocumentModel.Vml;
/// <summary>
///   Defines the Shadow Class.
/// </summary>
public partial class Shadow : ModelElement<DXV.Shadow>
{
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Id))]
    /// <summary>
    ///   Unique Identifier
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    ///   Shadow Toggle
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.On))]
    /// <summary>
    ///   Shadow Toggle
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public bool? On { get => _On; set => UpdateField(ref _On, value, nameof(On)); }

    private bool? _On;
    /// <summary>
    ///   Shadow Type
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Type))]
    /// <summary>
    ///   Shadow Type
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public ShadowKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private ShadowKind? _Type;
    /// <summary>
    ///   Shadow Transparency
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Obscured))]
    /// <summary>
    ///   Shadow Transparency
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public bool? Obscured { get => _Obscured; set => UpdateField(ref _Obscured, value, nameof(Obscured)); }

    private bool? _Obscured;
    /// <summary>
    ///   Shadow Primary Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Color))]
    /// <summary>
    ///   Shadow Primary Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Color { get => _Color; set => UpdateField(ref _Color, value, nameof(Color)); }

    private string? _Color;
    /// <summary>
    ///   Shadow Opacity
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Opacity))]
    /// <summary>
    ///   Shadow Opacity
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Opacity { get => _Opacity; set => UpdateField(ref _Opacity, value, nameof(Opacity)); }

    private string? _Opacity;
    /// <summary>
    ///   Shadow Primary Offset
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Offset))]
    /// <summary>
    ///   Shadow Primary Offset
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Offset { get => _Offset; set => UpdateField(ref _Offset, value, nameof(Offset)); }

    private string? _Offset;
    /// <summary>
    ///   Shadow Secondary Color
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Color2))]
    /// <summary>
    ///   Shadow Secondary Color
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Color2 { get => _Color2; set => UpdateField(ref _Color2, value, nameof(Color2)); }

    private string? _Color2;
    /// <summary>
    ///   Shadow Secondary Offset
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Offset2))]
    /// <summary>
    ///   Shadow Secondary Offset
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Offset2 { get => _Offset2; set => UpdateField(ref _Offset2, value, nameof(Offset2)); }

    private string? _Offset2;
    /// <summary>
    ///   Shadow Origin
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Origin))]
    /// <summary>
    ///   Shadow Origin
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Origin { get => _Origin; set => UpdateField(ref _Origin, value, nameof(Origin)); }

    private string? _Origin;
    /// <summary>
    ///   Shadow Perspective Matrix
    /// </summary>
    [OpenXmlProperty(nameof(DXV.Shadow.Matrix))]
    /// <summary>
    ///   Shadow Perspective Matrix
    /// </summary>
    [OpenXmlElement(typeof(DXV.Shadow))]
    public string? Matrix { get => _Matrix; set => UpdateField(ref _Matrix, value, nameof(Matrix)); }

    private string? _Matrix;
}