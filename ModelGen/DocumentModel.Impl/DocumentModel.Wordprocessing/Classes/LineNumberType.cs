namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public class LineNumberTypeImpl: ModelElement<DocumentFormat.OpenXml.Wordprocessing.LineNumberType>, LineNumberType
{
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  public LineNumberRestartKind? Restart
  {
    get => (LineNumberRestartKind?)OpenXmlElement?.Restart?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Restart = (DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues?)value;
    }
  }
  
}
