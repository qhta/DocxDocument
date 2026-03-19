
namespace DocumentModel.Interop.Core;

public interface IMsoErrorBars
{
  object Parent { get; }
  string Name { get; }
  object Select();
  IMsoBorder Border { get; }
  object Delete();
  object ClearFormats();
  XlEndStyleCap EndStyle { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
}