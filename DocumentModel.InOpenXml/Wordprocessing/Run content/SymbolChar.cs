namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a symbol character in a text run in WordprocessingML documents.
/// A symbol character is a special character that does not use any of the run fonts specified in the font table or style hierarchy. Instead, the character is determined by pulling the character with the specified hexadecimal value from the specified font.
/// </summary>
public partial class SymbolChar : ModelElement<DXW.SymbolChar>, IRunContent
{
    /// <summary>
    /// Font name from which the symbol character is selected.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.SymbolChar.Font))]
    public string? Font { get => _Font; set => UpdateField(ref _Font, value, nameof(Font)); }

    private string? _Font;
    /// <summary>
    /// Hexadecimal character code specifying the symbol to display from the given font.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.SymbolChar.Char))]
    public HexChar? Char { get => _Char; set => UpdateField(ref _Char, value, nameof(Char)); }

    private HexChar? _Char;
}