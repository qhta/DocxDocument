
namespace DocumentModel.Interop.Core;

public interface GridLines
{
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Delete();
  IMsoChartFormat Format { get; }
}