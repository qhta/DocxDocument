
namespace DocumentModel.Interop.Core;

public interface SoftEdgeFormat: InteropObject
{
  public MsoSoftEdgeType Type { get; set; }
  public float Radius { get; set; }
}
