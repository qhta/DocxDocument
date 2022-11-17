namespace DocumentModel.Drawing;

public interface IRotation // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? Latitude { get ; set; }

  public int? Longitude { get ; set; }

  public int? Revolution { get ; set; }

}
