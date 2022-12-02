namespace DocumentModel.Spreadsheet;

/// <summary>
/// Defines the Sparklines Class.
/// </summary>
public interface ISparklines // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ISparkline>? Sparklines { get ; set; }
  
}
