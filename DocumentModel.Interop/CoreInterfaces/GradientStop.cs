
namespace DocumentModel.Interop.Core;

public interface GradientStop: InteropObject
{
  public ColorFormat Color { get; }
  public float Position { get; set; }
  public float Transparency { get; set; }
}
