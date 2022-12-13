namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TableBorders Class.
/// </summary>
public class TableBordersImpl: ModelElementImpl, TableBorders
{
  public DocumentFormat.OpenXml.Wordprocessing.TableBorders? OpenXmlElement
  {
    get => (DocumentFormat.OpenXml.Wordprocessing.TableBorders?)_OpenXmlElement;
    set => _OpenXmlElement = value;
  }
  
  public TableBordersImpl(): base() {}
  
  public TableBordersImpl(DocumentFormat.OpenXml.Wordprocessing.TableBorders openXmlElement): base(openXmlElement)
  {
    OpenXmlElement = openXmlElement;
  }
  
  /// <summary>
  /// Table Top Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? TopBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Left Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? LeftBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// StartBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? StartBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Bottom Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? BottomBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Right Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? RightBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// EndBorder, this property is only available in Office 2010 and later..
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? EndBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Inside Horizontal Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? InsideHorizontalBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
  /// <summary>
  /// Table Inside Vertical Edges Border.
  /// </summary>
  public DocumentModel.Wordprocessing.BorderType? InsideVerticalBorder
  {
    get => throw new NotImplementedException("Method not implemented");
    set => throw new NotImplementedException("Method not implemented");
  }
  
}
