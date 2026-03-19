
namespace DocumentModel.Interop.Core;

public interface RulerLevel2: _IMsoDispObj
{
  new object Application { get; }
  new int Creator { get; }
  object Parent { get; }
  float FirstMargin { get; set; }
  float LeftMargin { get; set; }
}