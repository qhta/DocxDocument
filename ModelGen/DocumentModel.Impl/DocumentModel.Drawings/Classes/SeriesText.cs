namespace DocumentModel.Drawings;

/// <summary>
/// Series Text.
/// </summary>
public class SeriesTextImpl: ModelElementImpl, SeriesText
{
  public DocumentFormat.OpenXml.Drawing.Charts.SeriesText? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.SeriesText?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// StringReference.
  /// </summary>
  public StringReference? StringReference
  {
    get;
    set;
  }
  
  /// <summary>
  /// NumericValue.
  /// </summary>
  public String? NumericValue
  {
    get;
    set;
  }
  
}
