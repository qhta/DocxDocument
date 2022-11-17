namespace DocumentModel.Wordprocessing;

public interface IZoom // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public PresetZoom? Val { get ; set; }

  public string? Percent { get ; set; }

}
