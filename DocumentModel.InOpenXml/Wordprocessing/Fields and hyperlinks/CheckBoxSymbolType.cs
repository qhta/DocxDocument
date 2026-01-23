namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the symbol settings for a checkbox form field in a WordprocessingML document.
/// This class provides properties for specifying the font and symbol value used to display the checkbox, enabling advanced customization of checkbox appearance in forms and documents.
/// </summary>
public partial class CheckBoxSymbolType : ModelElement<DXO10W.CheckBoxSymbolType>
{
    /// <summary>
    /// Font used to display the checkbox symbol.
    /// </summary>
    public string? Font { get => _Font; set => UpdateField(ref _Font, value, nameof(Font)); }

    private string? _Font;
    /// <summary>
    /// Symbol value (as a hexadecimal character) used for the checkbox.
    /// </summary>
    public HexChar? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private HexChar? _Val;
}