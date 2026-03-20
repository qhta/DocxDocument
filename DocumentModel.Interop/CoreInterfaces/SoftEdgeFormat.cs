
namespace DocumentModel.Interop.Core;

public partial interface SoftEdgeFormat: InteropObject
{
  public MsoSoftEdgeType Type { get; set; }
  public float Radius { get; set; }
}
