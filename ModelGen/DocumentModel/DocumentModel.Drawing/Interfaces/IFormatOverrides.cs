namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public interface IFormatOverrides // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IFormatOverride>? FormatOverrides { get ; set; }
  
}
