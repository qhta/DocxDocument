namespace DocumentModel.Drawings10;


/// <summary>
///   Defines the BackgroundMark Class.
/// </summary>
public partial class BackgroundMark: ModelElement<DXO10D.BackgroundMark>
{
  public BackgroundMark(): base(){ }
  
  public BackgroundMark(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public BackgroundMark(DXO10D.BackgroundMark openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   x1, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? FirstXCoordinate
  {
    get
    {
      return _Element?.FirstXCoordinate?.Value;
    }
    set
    {
      _ExistingElement.FirstXCoordinate = value;
    }
  }
  
  
  /// <summary>
  ///   y1, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? FirstYCoordinate
  {
    get
    {
      return _Element?.FirstYCoordinate?.Value;
    }
    set
    {
      _ExistingElement.FirstYCoordinate = value;
    }
  }
  
  
  /// <summary>
  ///   x2, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SecondXCoordinate
  {
    get
    {
      return _Element?.SecondXCoordinate?.Value;
    }
    set
    {
      _ExistingElement.SecondXCoordinate = value;
    }
  }
  
  
  /// <summary>
  ///   y2, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? SecondYCoordinate
  {
    get
    {
      return _Element?.SecondYCoordinate?.Value;
    }
    set
    {
      _ExistingElement.SecondYCoordinate = value;
    }
  }
  
}
