
namespace DocumentModel.Interop.Core;

public interface GridLines
{
  string Name { get; }
  object Select();
  object Parent { get; }
  IMsoBorder Border { get; }
  object Delete();
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}