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
    get => (Int16?)OpenXmlElement?.CountBy?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.CountBy = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Line Numbering Starting Value
  /// </summary>
  public Int16? Start
  {
    get => (Int16?)OpenXmlElement?.Start?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Start = (System.Int16?)value;
    }
  }
  
  /// <summary>
  /// Distance Between Text and Line Numbering
  /// </summary>
  public String? Distance
  {
    get => (String?)OpenXmlElement?.Distance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Distance = (System.String?)value;
    }
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
