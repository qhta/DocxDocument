namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Hyperlinks Class.
/// </summary>
public interface IHyperlinks // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IHyperlink>? Hyperlinks { get ; set; }
  
}
