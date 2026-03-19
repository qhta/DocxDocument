
namespace DocumentModel.Interop.Core;

public interface IMsoDropLines
{
  string Name { get; }
  void Select();
  object Parent { get; }
  IMsoBorder Border { get; }
  void Delete();
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}