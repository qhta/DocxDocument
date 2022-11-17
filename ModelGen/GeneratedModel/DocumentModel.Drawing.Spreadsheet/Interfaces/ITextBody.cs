namespace DocumentModel.Drawing.Spreadsheet;

public interface ITextBody // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IBodyProperties? BodyProperties { get ; set; }

  public IListStyle? ListStyle { get ; set; }

}
