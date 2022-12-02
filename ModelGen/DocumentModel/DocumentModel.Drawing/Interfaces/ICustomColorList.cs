namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public interface ICustomColorList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<ICustomColor>? CustomColors { get ; set; }
  
}
