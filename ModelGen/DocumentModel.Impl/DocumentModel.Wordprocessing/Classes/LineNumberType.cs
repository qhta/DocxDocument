namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public class LineNumberTypeImpl: ModelElementImpl, LineNumberType
{
  public DocumentFormat.OpenXml.Wordprocessing.LineNumberType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LineNumberType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  public Int16? CountBy
  {
    get;
    set;
  }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  public Int16? Start
  {
    get;
    set;
  }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  public String? Distance
  {
    get;
    set;
  }
  
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
