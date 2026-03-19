namespace DocumentModel.Drawings.Diagrams;
/// <summary>
///   Style Label.
/// </summary>
[OpenXmlType(typeof(DXDD.StyleLabel))]
public partial class StyleLabel : ModelElement<DXDD.StyleLabel>
{
  /// <summary>
  ///   Style Name
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleLabel.Name))]
  public string? Name { get => _Name; set => UpdateField(ref _Name, value, nameof(Name)); }

  private string? _Name;
  /// <summary>
  ///   3-D Scene.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleLabel.Scene3D))]
  public Scene3D? Scene3D { get => _Scene3D; set => UpdateField(ref _Scene3D, value, nameof(Scene3D)); }

  private Scene3D? _Scene3D;
  /// <summary>
  ///   3-D Shape Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleLabel.Shape3D))]
  public Shape3D? Shape3D { get => _Shape3D; set => UpdateField(ref _Shape3D, value, nameof(Shape3D)); }

  private Shape3D? _Shape3D;
  /// <summary>
  ///   Text Properties.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleLabel.TextProperties))]
  public TextProperties? TextProperties { get => _TextProperties; set => UpdateField(ref _TextProperties, value, nameof(TextProperties)); }

  private TextProperties? _TextProperties;
  /// <summary>
  ///   Shape Style.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleLabel.Style))]
  public Style? Style { get => _Style; set => UpdateField(ref _Style, value, nameof(Style)); }

  private Style? _Style;
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [OpenXmlProperty(nameof(DXDD.StyleLabel.ExtensionList))]
  public ExtensionList? ExtensionList { get => _ExtensionList; set => UpdateField(ref _ExtensionList, value, nameof(ExtensionList)); }

  private ExtensionList? _ExtensionList;
}