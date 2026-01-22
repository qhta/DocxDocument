namespace DocumentModel.Drawings;
/// <summary>
///   Represents a text run, including character properties and the text string.
/// </summary>
public partial class Run : ModelElement
{
    /// <summary>
    ///   Character properties applied to the text run.
    /// </summary>
    public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }

    private RunProperties? _RunProperties;
    /// <summary>
    ///   Text string content of the run.
    /// </summary>
    public string? Text { get; set; }
}