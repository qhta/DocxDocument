namespace DocumentModel.Office2013.Drawing.ChartStyle;

public interface IEffectReference // : DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.StyleReference
{
  public uint? Index { get ; set; }

  public List<string>? Modifiers { get ; set; }

}
