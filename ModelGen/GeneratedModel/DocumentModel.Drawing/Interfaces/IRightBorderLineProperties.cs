namespace DocumentModel.Drawing;

public interface IRightBorderLineProperties // : DocumentFormat.OpenXml.Drawing.LinePropertiesType
{
  public int? Width { get ; set; }

  public DocumentModel.Drawing.LineCap? CapType { get ; set; }

  public DocumentModel.Drawing.CompoundLine? CompoundLineType { get ; set; }

  public DocumentModel.Drawing.PenAlignment? Alignment { get ; set; }

}
