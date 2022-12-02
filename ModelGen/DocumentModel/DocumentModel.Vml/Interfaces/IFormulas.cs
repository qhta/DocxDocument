namespace DocumentModel.Vml;

/// <summary>
/// Defines the Formulas Class.
/// </summary>
public interface IFormulas // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IFormula>? Formulas { get ; set; }
  
}
