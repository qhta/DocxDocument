
namespace DocumentModel.Interop.Core;

public partial interface IMsoWalls
{
  public string Name { get; }
  public IMsoBorder Border { get; }
  public IMsoInterior Interior { get; }
  public ChartFillFormat Fill { get; }
  public object PictureType { get; set; }
  public object PictureUnit { get; set; }
  public int Thickness { get; set; }
  public IMsoChartFormat Format { get; }
}
