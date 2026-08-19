namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents a symbol character in a text run in WordprocessingML documents.
/// A symbol character is a special character that does not use any of the run fonts specified in the font table or style hierarchy. Instead, the character is determined by pulling the character with the specified hexadecimal value from the specified font.
/// </summary>
[OpenXmlType(typeof(DXW.SymbolChar))]
[DataContract]
[XmlRoot("SymbolChar", Namespace = "DocumentModel.Wordprocessing")]
public partial class SymbolChar : ModelElement<DXW.SymbolChar>, IRunContent
{
  /// <summary>
  /// Initializes a new instance of the <see cref="SymbolChar"/> class.
  /// </summary>
  public SymbolChar() { }

  /// <summary>
  /// Initializes a new instance of the <see cref="SymbolChar"/> class.
  /// </summary>
  /// <param name="symbolChar">The underlying DXW.SymbolChar element.</param>
  public SymbolChar (DXW.SymbolChar symbolChar) : base(symbolChar) { }

  /// <summary>
  /// TextFormat name from which the symbol character is selected.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SymbolChar.Font))]
  public string? Font { get => _Font ??= GetProperty<string?>(GetUpdatableElement()?.Font); set => UpdateField(ref _Font, value, nameof(Font)); }
  private string? _Font;

  /// <summary>
  /// Hexadecimal character code specifying the symbol to display from the given font.
  /// </summary>
  [OpenXmlProperty(nameof(DXW.SymbolChar.Char))]
  public HexChar? Char { get => _Char ??= GetProperty<HexChar?>(GetUpdatableElement()?.Char); set => UpdateField(ref _Char, value, nameof(Char)); }
  private HexChar? _Char;

  /// <summary>
  /// Gets the Unicode character corresponding to the symbol character, if available.
  /// </summary>
  /// <returns>The Unicode character if available; otherwise, null.</returns>
  public Char? GetUnicodeChar()
  {
    if (Font == null || Char == null)
      return null;

    var hexChar = Char!;
    if (hexChar >= 0xF000 && hexChar <= 0xF0FF)
      hexChar = hexChar - 0xF000;
    var newHexChar = SymbolCharCodec.GetHexChar(Font, hexChar.ToChar());
    if (newHexChar != null && newHexChar<=0xFFFF)
      return (char)newHexChar;
    return null;
  }
}