namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Page Setup.
/// </summary>
public partial class PageSetup: ModelElement<DXDC.PageSetup>
{
  public PageSetup(): base(){ }
  
  public PageSetup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageSetup(DXDC.PageSetup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Page Size
  /// </summary>
  [DataMember]
  public UInt32? PaperSize
  {
    get
    {
      return _Element?.PaperSize?.Value;
    }
    set
    {
      _ExistingElement.PaperSize = value;
    }
  }
  
  
  /// <summary>
  ///   First Page Number
  /// </summary>
  [DataMember]
  public Int32? FirstPageNumber
  {
    get
    {
      return _Element?.FirstPageNumber?.Value;
    }
    set
    {
      _ExistingElement.FirstPageNumber = value;
    }
  }
  
  
  /// <summary>
  ///   Black and White
  /// </summary>
  [DataMember]
  public Boolean? BlackAndWhite
  {
    get
    {
      return _Element?.BlackAndWhite?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.BlackAndWhite = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.BlackAndWhite = null;
    }
  }
  
  
  /// <summary>
  ///   Draft
  /// </summary>
  [DataMember]
  public Boolean? Draft
  {
    get
    {
      return _Element?.Draft?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.Draft = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Draft = null;
    }
  }
  
  
  /// <summary>
  ///   Use First Page Number
  /// </summary>
  [DataMember]
  public Boolean? UseFirstPageNumber
  {
    get
    {
      return _Element?.UseFirstPageNumber?.Value;
    }
    set
    {
      if (value != null)
        _ExistingElement.UseFirstPageNumber = new DX.BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.UseFirstPageNumber = null;
    }
  }
  
  
  /// <summary>
  ///   Horizontal DPI
  /// </summary>
  [DataMember]
  public Int32? HorizontalDpi
  {
    get
    {
      return _Element?.HorizontalDpi?.Value;
    }
    set
    {
      _ExistingElement.HorizontalDpi = value;
    }
  }
  
  
  /// <summary>
  ///   Vertical DPI
  /// </summary>
  [DataMember]
  public Int32? VerticalDpi
  {
    get
    {
      return _Element?.VerticalDpi?.Value;
    }
    set
    {
      _ExistingElement.VerticalDpi = value;
    }
  }
  
  
  /// <summary>
  ///   Copies
  /// </summary>
  [DataMember]
  public UInt32? Copies
  {
    get
    {
      return _Element?.Copies?.Value;
    }
    set
    {
      _ExistingElement.Copies = value;
    }
  }
  
}
