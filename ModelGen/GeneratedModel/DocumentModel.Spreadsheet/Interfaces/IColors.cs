namespace DocumentModel.Spreadsheet;

public interface IColors // : DocumentFormat.OpenXml.TypedOpenXmlCompositeElement
{
  public IIndexedColors? IndexedColors { get ; set; }

  public IMruColors? MruColors { get ; set; }

}
