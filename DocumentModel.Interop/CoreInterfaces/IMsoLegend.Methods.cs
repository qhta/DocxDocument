
namespace DocumentModel.Interop.Core;

public partial interface IMsoLegend
{
  public object Select();
  public object Delete();
  public object LegendEntries(object Index);
  public object Clear();
}
