namespace DocumentModel.Drawing.Diagrams;

/// <summary>
/// Constraint List.
/// </summary>
public interface IConstraints // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.Diagrams.IConstraint>? Constraints { get ; set; }
  
}
