namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the RgbColorModelHex Class.
/// </summary>
public class RgbColorModelHexImpl: ModelElement<DocumentFormat.OpenXml.Office2010.Word.RgbColorModelHex>, RgbColorModelHex
{
  /// <summary>
  /// val, this property is only available in Office 2010 and later.
  /// </summary>
  public String? Val
  {
    get;
    set;
  }
  
}
