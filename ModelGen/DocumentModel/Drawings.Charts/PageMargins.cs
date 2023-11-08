namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Page Margins.
/// </summary>
public partial class PageMargins: ModelElement<DXDC.PageMargins>
{
  public PageMargins(): base(){ }
  
  public PageMargins(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageMargins(DXDC.PageMargins openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Left
  /// </summary>
  [DataMember]
  public Double? Left
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
  ///   Right
  /// </summary>
  [DataMember]
  public Double? Right
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
  ///   Top
  /// </summary>
  [DataMember]
  public Double? Top
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
  ///   Bottom
  /// </summary>
  [DataMember]
  public Double? Bottom
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
  
  
  /// <summary>
  ///   Header
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
  ///   Footer
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
