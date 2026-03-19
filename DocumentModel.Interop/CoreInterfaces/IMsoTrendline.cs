
namespace DocumentModel.Interop.Core;

public interface IMsoTrendline
{
  object Parent { get; }
  double Backward { get; set; }
  IMsoBorder Border { get; }
  object ClearFormats();
  IMsoDataLabel DataLabel { get; }
  object Delete();
  bool DisplayEquation { get; set; }
  bool DisplayRSquared { get; set; }
  double Forward { get; set; }
  int Index { get; }
  double Intercept { get; set; }
  bool InterceptIsAuto { get; set; }
  string Name { get; set; }
  bool NameIsAuto { get; set; }
  int Order { get; set; }
  int Period { get; set; }
  object Select();
  XlTrendlineType Type { get; set; }
  IMsoChartFormat Format { get; }
  object Application { get; }
  int Creator { get; }
  double Backward2 { get; set; }
  double Forward2 { get; set; }
}