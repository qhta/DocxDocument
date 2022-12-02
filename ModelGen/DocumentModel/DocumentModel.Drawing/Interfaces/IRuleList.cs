namespace DocumentModel.Drawing;

/// <summary>
/// Rule List.
/// </summary>
public interface IRuleList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IRule>? Rules { get ; set; }
  
}
