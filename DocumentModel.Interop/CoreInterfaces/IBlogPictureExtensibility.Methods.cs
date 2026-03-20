
namespace DocumentModel.Interop.Core;

public partial interface IBlogPictureExtensibility
{
  public void BlogPictureProviderProperties(out string BlogPictureProvider, out string FriendlyName);
  public void CreatePictureAccount(string Account, string BlogProvider, int ParentWindow, object Document);
  public void PublishPicture
    (string Account, int ParentWindow, object Document, object Image, out string PictureURI, int ImageType);
}
