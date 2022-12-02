namespace DocumentModel.Drawing;

/// <summary>
/// Defines the ExtraColorSchemeList Class.
/// </summary>
public interface IExtraColorSchemeList // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IExtraColorScheme>? ExtraColorSchemes { get ; set; }
  
}
