namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PageMargin Class.
/// </summary>
public partial class PageMargin: ModelElement<DXW.PageMargin>
{
  public PageMargin(): base(){ }
  
  public PageMargin(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageMargin(DXW.PageMargin openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Top Margin Spacing
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
  ///   Right Margin Spacing
  /// </summary>
  [DataMember]
  public UInt32? Right
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
  ///   Page Bottom Spacing
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
  
  
  /// <summary>
  ///   Left Margin Spacing
  /// </summary>
  [DataMember]
  public UInt32? Left
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
  ///   Spacing to Top of Header
  /// </summary>
  [DataMember]
  public UInt32? Header
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
  ///   Spacing to Bottom of Footer
  /// </summary>
  [DataMember]
  public UInt32? Footer
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
  
  
  /// <summary>
  ///   Page Gutter Spacing
  /// </summary>
  [DataMember]
  public UInt32? Gutter
  {
    get
    {
      return _Element?.Gutter?.Value;
    }
    set
    {
      _ExistingElement.Gutter = value;
    }
  }
  
}
