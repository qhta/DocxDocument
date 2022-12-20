using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace DocxDocument.Model;

public class Zoom: DocxBasedElement<WD.Zoom>, IZoom
{
  public Zoom() : base(new WD.Zoom())
  {
  }

  public Zoom(WD.Zoom element) : base(element)
  {
  }

  [Required]
  public Percentage? Percent
  {
    get => DocxRead.ReadPercentage(DocxElement.Percent);
    set => DocxElement.Percent = (value != null) ? ((int)value).ToString() : null;
  }

  public DM.PresetZoom? Preset
  {
    get => (DM.PresetZoom?)DocxElement.Val?.Value;
    set => DocxElement.Val = (value!=null) ? (WD.PresetZoomValues)value : null;
  }

  public override string ToString()
  {
    if (Preset==null)
      return Percent.ToString();
    return $"({Percent}, {Preset})";
  }
}