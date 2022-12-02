namespace DocumentModel.Drawing;

/// <summary>
/// Constraint List.
/// </summary>
public interface IConstraints // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IConstraint>? Constraints { get ; set; }
  
}
