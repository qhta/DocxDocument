namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Non-Visual Picture Drawing Properties.
/// </summary>
public partial class NonVisualPictureDrawingProperties : ModelElement<DXDP.NonVisualDrawingProperties>
{
    /// <summary>
    ///   preferRelativeResize
    /// </summary>
    public bool? PreferRelativeResize { get => _PreferRelativeResize; set => UpdateField(ref _PreferRelativeResize, value, nameof(PreferRelativeResize)); }

    private bool? _PreferRelativeResize;
    /// <summary>
    ///   PictureLocks.
    /// </summary>
    public PictureLocks? PictureLocks { get; set; }
    /// <summary>
    ///   NonVisualPicturePropertiesExtensionList.
    /// </summary>
    public NonVisualPicturePropertiesExtensionList? NonVisualPicturePropertiesExtensionList { get; set; }
}