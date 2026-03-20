
namespace DocumentModel.Interop.Core;

public partial interface WebComponentFormat
{
  public string URL { get; set; }
  public string HTML { get; set; }
  public string Name { get; set; }
  public int Width { get; set; }
  public int Height { get; set; }
  public string PreviewGraphic { get; set; }
}
