
namespace DocumentModel.Interop.Core;

public interface LineFormat: InteropObject
{
  ColorFormat BackColor { get; set; }
  MsoArrowheadLength BeginArrowheadLength { get; set; }
  MsoArrowheadStyle BeginArrowheadStyle { get; set; }
  MsoArrowheadWidth BeginArrowheadWidth { get; set; }
  MsoLineDashStyle DashStyle { get; set; }
  MsoArrowheadLength EndArrowheadLength { get; set; }
  MsoArrowheadStyle EndArrowheadStyle { get; set; }
  MsoArrowheadWidth EndArrowheadWidth { get; set; }
  ColorFormat ForeColor { get; set; }
  MsoPatternType Pattern { get; set; }
  MsoLineStyle Style { get; set; }
  float Transparency { get; set; }
  MsoTriState Visible { get; set; }
  float Weight { get; set; }
  MsoTriState InsetPen { get; set; }
}