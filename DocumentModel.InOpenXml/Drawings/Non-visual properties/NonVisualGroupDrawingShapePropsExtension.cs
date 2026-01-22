namespace DocumentModel.Drawings;
/// <summary>
///   Defines the NonVisualGroupDrawingShapePropsExtension interface.
/// </summary>
public partial class NonVisualGroupDrawingShapePropsExtension : ModelElement<DXD.NonVisualGroupDrawingShapePropsExtension>, IExtension
{
    public NonVisualGroupProperties? NonVisualGroupProperties { get => _NonVisualGroupProperties; set => UpdateField(ref _NonVisualGroupProperties, value, nameof(NonVisualGroupProperties)); }

    private NonVisualGroupProperties? _NonVisualGroupProperties;

    /// <summary>
    /// Uri
    /// </summary>
    public string? Uri { get; set; }
}