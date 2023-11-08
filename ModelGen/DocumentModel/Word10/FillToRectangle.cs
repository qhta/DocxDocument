namespace DocumentModel.Word10;


/// <summary>
///   Defines the FillToRectangle Class.
/// </summary>
public partial class FillToRectangle: ModelElement<DXO10W.FillToRectangle>
{
  public FillToRectangle(): base(){ }
  
  public FillToRectangle(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FillToRectangle(DXO10W.FillToRectangle openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   l, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Left
  {
    get
    {
      return _Element?.Left?.Value;
    }
    set
    {
      _ExistingElement.Left = value;
    }
  }
  
  
  /// <summary>
  ///   t, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Top
  {
    get
    {
      return _Element?.Top?.Value;
    }
    set
    {
      _ExistingElement.Top = value;
    }
  }
  
  
  /// <summary>
  ///   r, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Right
  {
    get
    {
      return _Element?.Right?.Value;
    }
    set
    {
      _ExistingElement.Right = value;
    }
  }
  
  
  /// <summary>
  ///   b, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public Int32? Bottom
  {
    get
    {
      return _Element?.Bottom?.Value;
    }
    set
    {
      _ExistingElement.Bottom = value;
    }
  }
  
}
