
namespace DocumentModel.Interop.Core;

public interface WebComponent
{
  public object Shape { get; }
  public string URL { get; set; }
  public string HTML { get; set; }
  public string Name { get; set; }
  public int Width { get; set; }
  public int Height { get; set; }
  public void SetPlaceHolderGraphic(string PlaceHolderGraphic);
  public void Commit();
  public void Revert();
}
