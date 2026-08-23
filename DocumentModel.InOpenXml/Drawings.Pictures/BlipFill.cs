namespace DocumentModel.Drawings.Pictures;

/// <summary>
///   Represents a picture fill in DrawingML, providing configuration for image-based fills in shapes and graphical elements.
///   Supports DPI settings, rotation, image source, cropping, tiling, and stretching for advanced picture fill effects.
/// </summary>
[OpenXmlType(typeof(DXDP.BlipFill))]
[DataContract]
[XmlRoot("BlipFill", Namespace = "DocumentModel.Drawings.Pictures")]
public partial class BlipFill: ModelElement<DXDP.BlipFill>
{
  /// <summary>
  ///   Dots per inch (DPI) setting for the picture fill, controlling image resolution and scaling.
  /// </summary>
  [OpenXmlProperty(nameof(DXDP.BlipFill.Dpi))]
  public UInt32? Dpi
  {
    get => _Dpi ??= GetProperty<UInt32?>(GetUpdatableElement()?.Dpi);
    set => UpdateField(ref _Dpi, value, nameof(Dpi));
  }

  private UInt32? _Dpi;

  /// <summary>
  ///   Indicates whether the picture fill rotates with the shape when the shape is rotated.
  /// </summary>
  [OpenXmlProperty(nameof(DXDP.BlipFill.RotateWithShape))]
  public bool? RotateWithShape
  {
    get => _RotateWithShape ??= GetProperty<bool?>(GetUpdatableElement()?.RotateWithShape);
    set => UpdateField(ref _RotateWithShape, value, nameof(RotateWithShape));
  }

  private bool? _RotateWithShape;

  /// <summary>
  ///   The image (blip) used for the picture fill, referencing the embedded or linked image data.
  /// </summary>
  [OpenXmlProperty(nameof(DXDP.BlipFill.Blip))]
  public Blip? Blip
  {
    get => _Blip ??= GetProperty<Blip?>(GetUpdatableElement()?.Blip);
    set => UpdateField(ref _Blip, value, nameof(Blip));
  }

  private Blip? _Blip;

  /// <summary>
  ///   Source rectangle for cropping the image, specifying the portion of the image to use for the fill.
  /// </summary>
  [OpenXmlProperty(nameof(DXDP.BlipFill.SourceRectangle))]
  public RelativeRectangleType? SourceRectangle
  {
    get => _SourceRectangle ??= GetProperty<RelativeRectangleType?>(GetUpdatableElement()?.SourceRectangle);
    set => UpdateField(ref _SourceRectangle, value, nameof(SourceRectangle));
  }

  private RelativeRectangleType? _SourceRectangle;

  /// <summary>
  ///   Tiling configuration for the picture fill, specifying how the image is repeated to fill the shape.
  /// </summary>
  public Tile? Tile { get => _Tile; set => UpdateField(ref _Tile, value, nameof(Tile)); }

  private Tile? _Tile;

  /// <summary>
  ///   Stretch configuration for the picture fill, specifying how the image is stretched to fit the shape.
  /// </summary>
  public Stretch? Stretch { get => _Stretch; set => UpdateField(ref _Stretch, value, nameof(Stretch)); }

  private Stretch? _Stretch;
}