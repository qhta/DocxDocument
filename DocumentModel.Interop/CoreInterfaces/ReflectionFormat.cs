
namespace DocumentModel.Interop.Core;

public interface ReflectionFormat: InteropObject
{
  public MsoReflectionType Type { get; set; }
  public float Transparency { get; set; }
  public float Size { get; set; }
  public float Offset { get; set; }
  public float Blur { get; set; }
}
