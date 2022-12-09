namespace DocumentModel.Drawings;

/// <summary>
/// Number Format.
/// </summary>
public class NumberingFormat2Impl: ModelElementImpl, NumberingFormat2
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
    get => (String?)OpenXmlElement?.FormatCode?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.FormatCode = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Linked to Source
  /// </summary>
  public Boolean? SourceLinked
  {
    get => (Boolean?)OpenXmlElement?.SourceLinked?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.SourceLinked = (System.Boolean?)value;
    }
  }
  
}
