namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Non-Visual Picture Properties.
/// </summary>
public partial class NonVisualPictureProperties : ModelElement<DXDP.NonVisualDrawingProperties>
{
    /// <summary>
    ///   Non-Visual Drawing Properties.
    /// </summary>
    public NonVisualDrawingProperties? NonVisualDrawingProperties { get => _NonVisualDrawingProperties; set => UpdateField(ref _NonVisualDrawingProperties, value, nameof(NonVisualDrawingProperties)); }

    private NonVisualDrawingProperties? _NonVisualDrawingProperties;
    /// <summary>
    ///   Non-Visual Picture Drawing Properties.
    /// </summary>
    public NonVisualPictureDrawingProperties? NonVisualPictureDrawingProperties { get => _NonVisualPictureDrawingProperties; set => UpdateField(ref _NonVisualPictureDrawingProperties, value, nameof(NonVisualPictureDrawingProperties)); }

    private NonVisualPictureDrawingProperties? _NonVisualPictureDrawingProperties;
}