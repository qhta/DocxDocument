namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the numbering format for a numbering definition in a WordprocessingML document.
/// This class provides properties for specifying the standard numbering format type and a custom number format using XSLT syntax, enabling advanced customization of list and outline numbering styles.
/// </summary>
public partial class NumberingFormat : ModelElement<DXW.NumberingFormat>
{
    /// <summary>
    /// Standard numbering format type, specifying the built-in numbering style (e.g., decimal, roman, bullet).
    /// </summary>
    [OpenXmlElement(typeof(DXW.NumberingFormat))]
    public NumberFormatKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private NumberFormatKind? _Type;
    /// <summary>
    /// Custom number format using XSLT format attribute syntax. This format is used for all numbering in the parent object (e.g., Katakana numbering).
    /// </summary>
    [OpenXmlElement(typeof(DXW.NumberingFormat))]
    public string? Custom { get => _Custom; set => UpdateField(ref _Custom, value, nameof(Custom)); }

    private string? _Custom;
}