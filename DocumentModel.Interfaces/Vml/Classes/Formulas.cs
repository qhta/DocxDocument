namespace DocumentModel.Vml;

/// <summary>
///   Defines the Formulas Class.
/// </summary>
public interface Formulas: IModelElement
{
  public Collection<Formula>? Items { get; set; }
}