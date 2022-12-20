namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the LineNumberType Class.
/// </summary>
public partial class LineNumberTypeImpl: ModelElementImpl, LineNumberType
{
  public DocumentFormat.OpenXml.Wordprocessing.LineNumberType? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.LineNumberType?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public LineNumberTypeImpl(): base() {}
  
  public LineNumberTypeImpl(DocumentFormat.OpenXml.Wordprocessing.LineNumberType openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Line Number Increments to Display
  /// </summary>
  public Int16? CountBy
  {
    get => (System.Int16?)OpenXmlElement?.CountBy?.Value;
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
    get => (System.Int16?)OpenXmlElement?.Start?.Value;
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
    get => (System.String?)OpenXmlElement?.Distance?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Distance = (System.String?)value;
    }
  }
  
  /// <summary>
  /// Line Numbering Restart Setting
  /// </summary>
  public DocumentModel.Wordprocessing.LineNumberRestartKind? Restart
  {
    get => (DocumentModel.Wordprocessing.LineNumberRestartKind?)OpenXmlElement?.Restart?.Value;
    set
    {
      if (OpenXmlElement != null)
        OpenXmlElement.Restart = (DocumentFormat.OpenXml.Wordprocessing.LineNumberRestartValues?)value;
    }
  }
  
}
