namespace DocumentModel.Drawing;

/// <summary>
/// Defines the FormatOverrides Class.
/// </summary>
public interface IFormatOverrides // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IFormatOverride>? FormatOverrides { get ; set; }
  
}
