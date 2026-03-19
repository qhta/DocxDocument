
namespace DocumentModel.Interop.Core;

public interface ReflectionFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoReflectionType Type { get; set; }
  float Transparency { get; set; }
  float Size { get; set; }
  float Offset { get; set; }
  float Blur { get; set; }
}