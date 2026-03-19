
namespace DocumentModel.Interop.Core;

public interface IMsoHiLoLines
{
  object Parent { get; }
  string Name { get; }
  void Select();
  IMsoBorder Border { get; }
  void Delete();
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}