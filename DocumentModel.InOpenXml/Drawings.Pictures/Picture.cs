namespace DocumentModel.Drawings.Pictures;
/// <summary>
///   Picture.
/// </summary>
public partial class Picture : ModelElement<DXDP.NonVisualDrawingProperties>
{
    /// <summary>
    ///   Non-Visual Picture Properties.
    /// </summary>
    public NonVisualPictureProperties? NonVisualPictureProperties { get => _NonVisualPictureProperties; set => UpdateField(ref _NonVisualPictureProperties, value, nameof(NonVisualPictureProperties)); }

    private NonVisualPictureProperties? _NonVisualPictureProperties;
    /// <summary>
    ///   Picture Fill.
    /// </summary>
    public BlipFill? BlipFill { get; set; }
    /// <summary>
    ///   Shape Properties.
    /// </summary>
    public ShapeProperties? ShapeProperties { get; set; }
    /// <summary>
    ///   ShapeStyle.
    /// </summary>
    public ShapeStyle? ShapeStyle { get; set; }
    /// <summary>
    ///   OfficeArtExtensionList.
    /// </summary>
    public OfficeArtExtensionList? OfficeArtExtensionList { get; set; }
}