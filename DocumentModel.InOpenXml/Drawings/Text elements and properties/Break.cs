namespace DocumentModel.Drawings;
/// <summary>
/// Represents a text line break within a drawing, optionally including run properties for the break.
/// </summary>
public partial class Break : ModelElement<DXW.Break>
{
    /// <summary>
    /// Text run properties applied to the break.
    /// </summary>
    [OpenXmlElement(typeof(DXW.Break))]
    public RunProperties? RunProperties { get => _RunProperties; set => UpdateField(ref _RunProperties, value, nameof(RunProperties)); }

    private RunProperties? _RunProperties;
}