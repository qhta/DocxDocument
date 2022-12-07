namespace DocumentModel.Drawings;

/// <summary>
/// Series Text.
/// </summary>
public class SeriesTextImpl: ModelElement<DocumentFormat.OpenXml.Drawing.Charts.SeriesText>, SeriesText
{
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference
  {
    get;
    set;
  }
  
}
