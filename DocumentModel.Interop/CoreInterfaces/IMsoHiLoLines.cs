
namespace DocumentModel.Interop.Core;

public interface IMsoHiLoLines
{
  string Name { get; }
  void Select();
  IMsoBorder Border { get; }
  void Delete();
  IMsoChartFormat Format { get; }
}