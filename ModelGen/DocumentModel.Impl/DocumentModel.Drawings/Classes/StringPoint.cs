namespace DocumentModel.Drawings;

/// <summary>
/// String Point.
/// </summary>
public class StringPointImpl: ModelElementImpl, StringPoint
{
  public DocumentFormat.OpenXml.Drawing.Charts.StringPoint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.StringPoint?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Index
  /// </summary>
  public UInt32? Index
  {
    get;
    set;
  }
  
  /// <summary>
  /// Text Value.
  /// </summary>
  public String? NumericValue
  {
    get;
    set;
  }
  
}
