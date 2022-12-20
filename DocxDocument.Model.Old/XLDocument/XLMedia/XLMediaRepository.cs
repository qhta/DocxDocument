using DocumentFormat.OpenXml.Packaging;

namespace DocxToLatex.Converter.XLDocument.XLMedia;

/// <summary>
/// Repository containing media (images) data.
/// </summary>
public interface IXLMediaRepository
{
  /// <summary>
  /// Retrieves media resource for given resource name.
  /// </summary>
  /// <param name="resName">resourceName - the Uri path</param>
  XLMediaResource GetMediaResource(string resName);

}

public class XLMediaRepository : IXLMediaRepository
{
  private readonly IXLMediaFiller xlMediaFiler;
  private readonly IEnumerable<ImagePart> images;

  private IDictionary<string, ImagePart> imagesByName;

  public XLMediaRepository(IXLMediaFiller xlMediaFiller, WordprocessingDocument document)
  {
    this.xlMediaFiler = xlMediaFiller;
    this.images = document.MainDocumentPart.ImageParts;
  }

  public XLMediaResource GetMediaResource(string resName)
  {
    XLMediaResource resource = new XLMediaResource();
    this.FiilXLMediaResource(resource, resName);

    return resource;
  }

  private void FiilXLMediaResource(XLMediaResource resource, string resName)
  {
    var imagePart = this.GetImagePart(resName);

    this.xlMediaFiler.FillMediaResource(resource, imagePart);
  }

  private ImagePart GetImagePart(string resName)
  {
    if (this.imagesByName == null)
    {
      this.imagesByName = new Dictionary<string, ImagePart>();
    }

    if (!this.imagesByName.TryGetValue(resName, out ImagePart imagePart))
    {
      imagePart = (ImagePart)this.images
        .Where(e => e is ImagePart s)
        .SingleOrDefault(e => (e as ImagePart).Uri.LocalPath == resName);

      this.imagesByName[resName] = imagePart;
    }

    return imagePart;
  }
}