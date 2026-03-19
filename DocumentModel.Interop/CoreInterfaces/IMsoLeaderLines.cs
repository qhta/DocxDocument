
namespace DocumentModel.Interop.Core;

public interface IMsoLeaderLines
{
  void Select();
  IMsoBorder Border { get; }
  void Delete();
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
  object Parent { get; }
}