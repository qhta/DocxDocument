
namespace DocumentModel.Interop.Core;

public interface WebComponent
{
  object Shape { get; }
  string URL { get; set; }
  string HTML { get; set; }
  string Name { get; set; }
  int Width { get; set; }
  int Height { get; set; }
  void SetPlaceHolderGraphic(string PlaceHolderGraphic);
  void Commit();
  void Revert();
}