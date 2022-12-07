namespace DocumentModel.Drawings;

/// <summary>
/// Defines the ColorStyle Class.
/// </summary>
public class ColorStyleImpl: ModelElement<DocumentFormat.OpenXml.Office2013.Drawing.ChartStyle.ColorStyle>, ColorStyle
{
  public OfficeArtExtensionList1? OfficeArtExtensionList
  {
    get;
    set;
  }
  
}
