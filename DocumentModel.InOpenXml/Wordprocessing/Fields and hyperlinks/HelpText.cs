namespace DocumentModel.Wordprocessing;
/// <summary>
/// Represents help text associated with a form field in a WordprocessingML document.
/// This class provides properties for the type and value of help text, enabling advanced user guidance and contextual assistance for interactive form fields within documents.
/// </summary>
public partial class HelpText : ModelElement<DXW.HelpText>
{
    /// <summary>
    /// Type of help text, specifying the context or display mode (e.g., tooltip, status bar).
    /// </summary>
    [OpenXmlProperty(nameof(DXW.HelpText.Type))]
    public InfoTextKind? Type { get => _Type; set => UpdateField(ref _Type, value, nameof(Type)); }

    private InfoTextKind? _Type;
    /// <summary>
    /// Value of the help text, containing the actual guidance or information to be displayed to the user.
    /// </summary>
    [OpenXmlProperty(nameof(DXW.HelpText.Val))]
    public string? Val { get => _Val; set => UpdateField(ref _Val, value, nameof(Val)); }

    private string? _Val;
}