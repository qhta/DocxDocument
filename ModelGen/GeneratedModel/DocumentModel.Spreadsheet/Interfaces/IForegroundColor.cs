namespace DocumentModel.Spreadsheet;

public interface IForegroundColor // : DocumentFormat.OpenXml.Spreadsheet.ColorType
{
  public bool? Auto { get ; set; }

  public uint? Indexed { get ; set; }

  public IHexBinaryValue? Rgb { get ; set; }

  public uint? Theme { get ; set; }

  public double? Tint { get ; set; }

}
