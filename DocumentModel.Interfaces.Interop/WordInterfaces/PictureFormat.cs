namespace DocumentModel.Interop;

/// <summary>
/// Contains properties and methods that apply to pictures and OLE objects.
/// </summary>
public partial interface PictureFormat : InteropObject
{
  /// <summary>
  /// The brightness.
  /// </summary>
  public float Brightness { get; set; }

  /// <summary>
  /// The color type.
  /// </summary>
  //public Core.MsoPictureColorType ColorType { get; set; }

  /// <summary>
  /// The contrast.
  /// </summary>
  public float Contrast { get; set; }

  /// <summary>
  /// The crop bottom.
  /// </summary>
  public float CropBottom { get; set; }

  /// <summary>
  /// The crop left.
  /// </summary>
  public float CropLeft { get; set; }

  /// <summary>
  /// The crop right.
  /// </summary>
  public float CropRight { get; set; }

  /// <summary>
  /// The crop top.
  /// </summary>
  public float CropTop { get; set; }

  /// <summary>
  /// The transparency color.
  /// </summary>
  public int TransparencyColor { get; set; }

  /// <summary>
  /// The transparent background.
  /// </summary>
  //public Core.MsoTriState TransparentBackground { get; set; }

  /// <summary>
  /// The crop.
  /// </summary>
  //public Core.Crop Crop { get; set; }
}
