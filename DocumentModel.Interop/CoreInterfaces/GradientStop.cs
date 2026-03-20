
namespace DocumentModel.Interop.Core;

public partial interface GradientStop: InteropObject
{
  public ColorFormat Color { get; }
  public float Position { get; set; }
  public float Transparency { get; set; }
}
