namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public interface IExtraColorSchemeList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IExtraColorScheme>? ExtraColorSchemes { get ; set; }
  
}
