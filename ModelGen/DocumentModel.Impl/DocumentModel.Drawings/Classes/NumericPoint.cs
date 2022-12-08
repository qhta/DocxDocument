namespace DocumentModel.Drawings;

/// <summary>
/// Numeric Point.
/// </summary>
public class NumericPointImpl: ModelElementImpl, NumericPoint
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumericPoint? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumericPoint?)_OpenXmlElement;
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
  /// Number Format
  /// </summary>
  public String? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Numeric Value.
  /// </summary>
  public String? NumericValue
  {
    get;
    set;
  }
  
}
