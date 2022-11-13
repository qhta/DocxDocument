using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace DocxDocument.Model;

public interface IZoom
{
  [Required]
  public Percentage? Percent { get; set; }

  public DM.PresetZoom? Preset { get; set; }

}