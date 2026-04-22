using EnumConverter = DocumentModel.OpenXml.EnumTypeConverter;

namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the spacing settings between lines in a paragraph for a WordprocessingML document.
/// This class provides properties for specifying the spacing value and the rule used to determine line spacing, enabling advanced control over paragraph layout and readability.
/// </summary>
[XmlRoot("Interline", Namespace = "DocumentModel.Wordprocessing")]
public partial class Interline : ModelElement
{
 /// <summary>
 /// Spacing between lines in the paragraph, specified in twentieths of a point or as a multiple of line height.
 /// </summary>
 public Twips? Line { get => _Line; set => UpdateField(ref _Line, value, nameof(Line)); }
 private Twips? _Line;

 /// <summary>
 /// Type of spacing rule applied between lines (e.g., auto, exact, at least, multiple).
 /// </summary>
 public LineSpacingRule? LineRule { get => _LineRule; set => UpdateField(ref _LineRule, value, nameof(LineRule)); }
 private LineSpacingRule? _LineRule;
}