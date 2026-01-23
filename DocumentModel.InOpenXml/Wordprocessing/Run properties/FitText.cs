namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents the fit text effect for a text run, enabling the text to be compressed or expanded to fit a specified width.
/// This class provides properties for identifying the fit text run and specifying the target width in twips, allowing advanced text layout control in WordprocessingML documents.
/// </summary>
public partial class FitText : ModelElement<DXW.FitText>
{
    /// <summary>
    /// Identifier for the fit text run, used to distinguish multiple fit text effects within the same document.
    /// </summary>
    public Int32? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private Int32? _Id;
    /// <summary>
    /// Target width for the fit text effect, specified in twips. The text is compressed or expanded to fit this width.
    /// </summary>
    public Twips? Value { get => _Value; set => UpdateField(ref _Value, value, nameof(Value)); }

    private Twips? _Value;
}