
namespace DocumentModel.Interop.Core;

public interface IMsoCorners
{
  object Parent { get; }
  string Name { get; }
  object Select();
  object Application { get; }
  int Creator { get; }
}