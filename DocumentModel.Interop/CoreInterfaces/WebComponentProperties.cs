
namespace DocumentModel.Interop.Core;

public interface WebComponentProperties
{
  object Shape { get; }
  string Name { get; set; }
  string URL { get; set; }
  string HTML { get; set; }
  string PreviewGraphic { get; set; }
  string PreviewHTML { get; set; }
  int Width { get; set; }
  int Height { get; set; }
  string Tag { get; set; }
}