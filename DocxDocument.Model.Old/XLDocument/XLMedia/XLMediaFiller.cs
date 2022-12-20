using DocumentFormat.OpenXml.Packaging;

namespace DocxToLatex.Converter.XLDocument.XLMedia;

public interface IXLMediaFiller
{
  void FillMediaResource(XLMediaResource mediaResource, ImagePart imagePart);
}

public class XLMediaFiller : IXLMediaFiller
{
  public void FillMediaResource(XLMediaResource mediaResource, ImagePart imagePart)
  {
      
  }

}