namespace DocumentModel.Vml;

/// <summary>
///   Defines the TextPath Class.
/// </summary>
[OpenXmlType(typeof(DXV.TextPath))]
[DataContract]
[XmlRoot("TextPath", Namespace = "DocumentModel.Vml")]
public partial class TextPath: ModelElement<DXV.TextPath>
{
  /// <summary>
  ///   Unique Identifier
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.Id))]
  public string? Id
  {
    get => _Id ??= GetProperty<string?>(GetUpdatableElement()?.Id);
    set => UpdateField(ref _Id, value, nameof(Id));
  }

  private string? _Id;

  /// <summary>
  ///   Shape Styling Properties
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.Style))]
  public string? Style
  {
    get => _Style ??= GetProperty<string?>(GetUpdatableElement()?.Style);
    set => UpdateField(ref _Style, value, nameof(Style));
  }

  private string? _Style;

  /// <summary>
  ///   Text Path Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.On))]
  public bool? On
  {
    get => _On ??= GetProperty<bool?>(GetUpdatableElement()?.On);
    set => UpdateField(ref _On, value, nameof(On));
  }

  private bool? _On;

  /// <summary>
  ///   Shape Fit Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.FitShape))]
  public bool? FitShape
  {
    get => _FitShape ??= GetProperty<bool?>(GetUpdatableElement()?.FitShape);
    set => UpdateField(ref _FitShape, value, nameof(FitShape));
  }

  private bool? _FitShape;

  /// <summary>
  ///   Path Fit Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.FitPath))]
  public bool? FitPath
  {
    get => _FitPath ??= GetProperty<bool?>(GetUpdatableElement()?.FitPath);
    set => UpdateField(ref _FitPath, value, nameof(FitPath));
  }

  private bool? _FitPath;

  /// <summary>
  ///   Text Path Trim Toggle
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.Trim))]
  public bool? Trim
  {
    get => _Trim ??= GetProperty<bool?>(GetUpdatableElement()?.Trim);
    set => UpdateField(ref _Trim, value, nameof(Trim));
  }

  private bool? _Trim;

  /// <summary>
  ///   Text X-Scaling
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.XScale))]
  public bool? XScale
  {
    get => _XScale ??= GetProperty<bool?>(GetUpdatableElement()?.XScale);
    set => UpdateField(ref _XScale, value, nameof(XScale));
  }

  private bool? _XScale;

  /// <summary>
  ///   Text Path Text
  /// </summary>
  [OpenXmlProperty(nameof(DXV.TextPath.String))]
  public string? String
  {
    get => _String ??= GetProperty<string?>(GetUpdatableElement()?.String);
    set => UpdateField(ref _String, value, nameof(String));
  }

  private string? _String;
}