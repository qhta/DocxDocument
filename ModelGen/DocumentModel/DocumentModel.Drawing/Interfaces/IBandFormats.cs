namespace DocumentModel.Drawing;

/// <summary>
/// Band Formats.
/// </summary>
public interface IBandFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public System.Collections.ObjectModel.Collection<DocumentModel.Drawing.IBandFormat>? BandFormats { get ; set; }
  
}
