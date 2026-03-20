
namespace DocumentModel.Interop.Core;

public interface IMsoLeaderLines
{
  void Select();
  IMsoBorder Border { get; }
  void Delete();
  IMsoChartFormat Format { get; }
}