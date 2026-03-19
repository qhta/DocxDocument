
namespace DocumentModel.Interop.Core;

public interface IBlogPictureExtensibility
{
  void BlogPictureProviderProperties(out string BlogPictureProvider, out string FriendlyName);
  void CreatePictureAccount(string Account, string BlogProvider, int ParentWindow, object Document);

  void PublishPicture
    (string Account, int ParentWindow, object Document, object Image, out string PictureURI, int ImageType);
}