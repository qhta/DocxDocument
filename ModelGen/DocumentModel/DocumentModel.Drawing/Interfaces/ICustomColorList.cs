namespace DocumentModel.Drawing;

/// <summary>
/// Defines the CustomColorList Class.
/// </summary>
public interface ICustomColorList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.ICustomColor>? CustomColors { get ; set; }
  
}
