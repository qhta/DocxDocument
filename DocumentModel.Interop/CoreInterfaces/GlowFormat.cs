
namespace DocumentModel.Interop.Core;

public partial interface GlowFormat: InteropObject
{
  public float Radius { get; set; }
  public ColorFormat Color { get; }
  public float Transparency { get; set; }
}
