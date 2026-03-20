
namespace DocumentModel.Interop.Core;

public partial interface WebComponent
{
  public object Shape { get; }
  public string URL { get; set; }
  public string HTML { get; set; }
  public string Name { get; set; }
  public int Width { get; set; }
  public int Height { get; set; }
}
