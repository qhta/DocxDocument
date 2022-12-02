namespace DocumentModel.Drawing;

/// <summary>
/// Band Formats.
/// </summary>
public interface IBandFormats // : DocumentModel.ITypedOpenXmlCompositeElement
{
  public Collection<IBandFormat>? BandFormats { get ; set; }
  
}
