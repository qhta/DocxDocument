
namespace DocumentModel.Interop.Core;

public partial interface WebComponentProperties
{
  public object Shape { get; }
  public string Name { get; set; }
  public string URL { get; set; }
  public string HTML { get; set; }
  public string PreviewGraphic { get; set; }
  public string PreviewHTML { get; set; }
  public int Width { get; set; }
  public int Height { get; set; }
  public string Tag { get; set; }
}
