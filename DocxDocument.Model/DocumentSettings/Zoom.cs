using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace DocxDocument.Model;

public struct Zoom
{
  [Required]
  public Percentage? Percent { get; set; }

  public PresetZoom? Preset { get; set; }

  public override string ToString()
  {
    if (Preset==null)
      return Percent.ToString();
    return $"({Percent}, {Preset})";
  }
}