namespace DocumentModel.Wordprocessing;
/// <summary>
///  Grid Column Definition.
/// </summary>
public partial class GridColumn : ModelElement<DXW.GridColumn>
{
    /// <summary>
    ///   Grid Column Width
    /// </summary>
    [OpenXmlProperty(nameof(DXW.GridColumn.Width))]
    /// <summary>
    ///   Grid Column Width
    /// </summary>
    [OpenXmlElement(typeof(DXW.GridColumn))]
    public Twips? Width { get => _Width; set => UpdateField(ref _Width, value, nameof(Width)); }

    private Twips? _Width;
}