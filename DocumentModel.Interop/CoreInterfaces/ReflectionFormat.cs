
namespace DocumentModel.Interop.Core;

public interface ReflectionFormat: InteropObject
{
  MsoReflectionType Type { get; set; }
  float Transparency { get; set; }
  float Size { get; set; }
  float Offset { get; set; }
  float Blur { get; set; }
}