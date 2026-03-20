
namespace DocumentModel.Interop.Core;

public partial interface WebComponent
{
  public void SetPlaceHolderGraphic(string PlaceHolderGraphic);
  public void Commit();
  public void Revert();
}
