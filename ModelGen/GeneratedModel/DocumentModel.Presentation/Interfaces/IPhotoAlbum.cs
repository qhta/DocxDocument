namespace DocumentModel.Presentation;

public interface IPhotoAlbum // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public bool? BlackWhite { get ; set; }

  public bool? ShowCaptions { get ; set; }

  public PhotoAlbumLayout? Layout { get ; set; }

  public PhotoAlbumFrameShape? Frame { get ; set; }

  public DocumentModel.Presentation.IExtensionList? ExtensionList { get ; set; }

}
