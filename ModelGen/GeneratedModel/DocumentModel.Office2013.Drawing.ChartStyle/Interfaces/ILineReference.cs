namespace DocumentModel.Office2013.Drawing.ChartStyle;

public interface ILineReference // : DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference
{
  public uint? Index { get ; set; }
  
  public List<string>? Modifiers { get ; set; }
  
}
