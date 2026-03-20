
namespace DocumentModel.Interop.Core;

public interface SoftEdgeFormat: InteropObject
{
  MsoSoftEdgeType Type { get; set; }
  float Radius { get; set; }
}