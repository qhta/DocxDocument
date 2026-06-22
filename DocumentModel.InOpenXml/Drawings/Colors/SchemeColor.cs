namespace DocumentModel.Drawings;

/// <summary>
/// Represents a color that references a theme color scheme with optional transformations.
/// This class enables dynamic color theming in Word documents by referencing colors from the 
/// document's theme (e.g., Accent1, Dark1, Light2) rather than using fixed RGB values.
/// When the document theme changes, scheme colors automatically update to match the new theme.
/// </summary>
[OpenXmlType(typeof(DXD.SchemeColor))]
[XmlRoot("SchemeColor", Namespace = "DocumentModel.Drawings")]
public partial class SchemeColor: DrawingsColorBase<DXD.SchemeColor>, IDrawingColor
{

  /// <summary>
  /// Gets or sets the scheme color identifier that references a specific color role in the document theme.
  /// </summary>
  [OpenXmlProperty(nameof(DXD.SchemeColor.Val))]
  public SchemeColors? Index { get => _index; set => UpdateField(ref _index, value, nameof(Index)); }

  private SchemeColors? _index;
}