
namespace DocumentModel.Interop.Core;

public interface SoftEdgeFormat: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  MsoSoftEdgeType Type { get; set; }
  float Radius { get; set; }
}