
namespace DocumentModel.Interop.Core;

public partial interface LineFormat: InteropObject
{
  public ColorFormat BackColor { get; set; }
  public MsoArrowheadLength BeginArrowheadLength { get; set; }
  public MsoArrowheadStyle BeginArrowheadStyle { get; set; }
  public MsoArrowheadWidth BeginArrowheadWidth { get; set; }
  public MsoLineDashStyle DashStyle { get; set; }
  public MsoArrowheadLength EndArrowheadLength { get; set; }
  public MsoArrowheadStyle EndArrowheadStyle { get; set; }
  public MsoArrowheadWidth EndArrowheadWidth { get; set; }
  public ColorFormat ForeColor { get; set; }
  public MsoPatternType Pattern { get; set; }
  public MsoLineStyle Style { get; set; }
  public float Transparency { get; set; }
  public MsoTriState Visible { get; set; }
  public float Weight { get; set; }
  public MsoTriState InsetPen { get; set; }
}
