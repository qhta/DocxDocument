
namespace DocumentModel.Interop.Core;

public interface WebComponentFormat
{
  string URL { get; set; }
  string HTML { get; set; }
  string Name { get; set; }
  int Width { get; set; }
  int Height { get; set; }
  string PreviewGraphic { get; set; }
  void LaunchPropertiesWindow();
}