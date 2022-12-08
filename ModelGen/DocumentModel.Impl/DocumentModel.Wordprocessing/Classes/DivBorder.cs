namespace DocumentModel.Wordprocessing;

/// <summary>
/// Set of Borders for HTML div.
/// </summary>
public class DivBorderImpl: ModelElementImpl, DivBorder
{
  public DocumentFormat.OpenXml.Wordprocessing.DivBorder? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.DivBorder?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public BorderType? TopBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public BorderType? LeftBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public BorderType? BottomBorder
  {
    get;
    set;
  }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public BorderType? RightBorder
  {
    get;
    set;
  }
  
}
