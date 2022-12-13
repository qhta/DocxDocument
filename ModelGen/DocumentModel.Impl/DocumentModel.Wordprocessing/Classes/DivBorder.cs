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
  
  public DivBorderImpl(): base() {}
  
  public DivBorderImpl(DocumentFormat.OpenXml.Wordprocessing.DivBorder openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Top Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Left Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Bottom Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Right Border for HTML div.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
