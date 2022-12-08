namespace DocumentModel.Drawings;

/// <summary>
/// Number Format.
/// </summary>
public class NumberingFormat1Impl: ModelElementImpl, NumberingFormat1
{
  public DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Drawing.Charts.NumberingFormat?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Number Format Code
  /// </summary>
  public String? FormatCode
  {
    get;
    set;
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public Boolean? SourceLinked
  {
    get;
    set;
  }
  
}
