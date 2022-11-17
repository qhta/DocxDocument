namespace DocumentModel.Office2010.Excel;

public interface IMarkersColor // : DocumentFormat.OpenXml.Office2010.Excel.ColorType
{
  public bool? Auto { get ; set; }

  public uint? Indexed { get ; set; }

  public IHexBinaryValue? Rgb { get ; set; }

  public uint? Theme { get ; set; }

  public double? Tint { get ; set; }

}
