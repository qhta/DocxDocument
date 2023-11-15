namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the ForegroundMark Class.
/// </summary>
public partial class ForegroundMark: ModelElement<DXO10D.ForegroundMark>
{
  public ForegroundMark(): base(){ }
  
  public ForegroundMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ForegroundMark(DXO10D.ForegroundMark openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   x1, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? FirstXCoordinate
  {
    get => _Element?.FirstXCoordinate?.Value;
    set => _ExistingElement.FirstXCoordinate = value;
  }
  
  
  /// <summary>
  ///   y1, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? FirstYCoordinate
  {
    get => _Element?.FirstYCoordinate?.Value;
    set => _ExistingElement.FirstYCoordinate = value;
  }
  
  
  /// <summary>
  ///   x2, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SecondXCoordinate
  {
    get => _Element?.SecondXCoordinate?.Value;
    set => _ExistingElement.SecondXCoordinate = value;
  }
  
  
  /// <summary>
  ///   y2, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SecondYCoordinate
  {
    get => _Element?.SecondYCoordinate?.Value;
    set => _ExistingElement.SecondYCoordinate = value;
  }
  
}
