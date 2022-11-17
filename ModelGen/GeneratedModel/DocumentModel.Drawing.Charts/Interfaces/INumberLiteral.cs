namespace DocumentModel.Drawing.Charts;

public interface INumberLiteral // : DocumentFormat.OpenXml.Drawing.Charts.NumberDataType
{
  public IFormatCode? FormatCode { get ; set; }

  public IPointCount? PointCount { get ; set; }

}
