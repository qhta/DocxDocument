namespace DocumentModel.Drawing;

/// <summary>
/// Constraint List.
/// </summary>
public interface IConstraints // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IConstraint>? Constraints { get ; set; }
  
}
