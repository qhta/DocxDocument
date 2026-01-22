using DocumentModel.Wordprocessing;

namespace DocumentModel.Vml;
/// <summary>
/// Represents a VML text box element with styling and content properties.
/// </summary>
public partial class TextBox : ModelElement<DXV.TextBox>
{
    /// <summary>
    /// Unique identifier for the text box.
    /// </summary>
    public string? Id { get => _Id; set => UpdateField(ref _Id, value, nameof(Id)); }

    private string? _Id;
    /// <summary>
    /// CSS-style string specifying shape styling properties for the text box.
    /// </summary>
    public string? Style { get; set; }
    /// <summary>
    /// Inset margin values for the text box content.
    /// </summary>
    public string? Inset { get; set; }
    /// <summary>
    /// Indicates whether single-click selection is enabled for the text box.
    /// </summary>
    public bool? SingleClick { get; set; }
    /// <summary>
    /// Content of the text box, including paragraphs and runs.
    /// </summary>
    public TextBoxContent? TextBoxContent { get; set; }
}