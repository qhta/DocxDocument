namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PageMargins Class.
/// </summary>
public partial class PageMargins: ModelElement<DXO16DCD.PageMargins>
{
  public PageMargins(): base(){ }
  
  public PageMargins(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageMargins(DXO16DCD.PageMargins openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   l, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? L
  {
    get
    {
      return _Element?.L?.Value;
    }
    set
    {
      _ExistingElement.L = value;
    }
  }
  
  
  /// <summary>
  ///   r, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? R
  {
    get
    {
      return _Element?.R?.Value;
    }
    set
    {
      _ExistingElement.R = value;
    }
  }
  
  
  /// <summary>
  ///   t, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? T
  {
    get
    {
      return _Element?.T?.Value;
    }
    set
    {
      _ExistingElement.T = value;
    }
  }
  
  
  /// <summary>
  ///   b, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? B
  {
    get
    {
      return _Element?.B?.Value;
    }
    set
    {
      _ExistingElement.B = value;
    }
  }
  
  
  /// <summary>
  ///   header, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Header
  {
    get
    {
      return _Element?.Header?.Value;
    }
    set
    {
      _ExistingElement.Header = value;
    }
  }
  
  
  /// <summary>
  ///   footer, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public Double? Footer
  {
    get
    {
      return _Element?.Footer?.Value;
    }
    set
    {
      _ExistingElement.Footer = value;
    }
  }
  
}
