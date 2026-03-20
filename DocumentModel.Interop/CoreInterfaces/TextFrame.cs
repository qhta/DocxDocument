
namespace DocumentModel.Interop.Core;

public partial interface TextFrame: InteropObject
{
  public float MarginBottom { get; set; }
  public float MarginLeft { get; set; }
  public float MarginRight { get; set; }
  public float MarginTop { get; set; }
  public MsoTextOrientation Orientation { get; set; }
}
