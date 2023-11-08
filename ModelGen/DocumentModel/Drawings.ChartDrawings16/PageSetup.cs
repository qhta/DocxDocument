namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PageSetup Class.
/// </summary>
public partial class PageSetup: ModelElement<DXO16DCD.PageSetup>
{
  public PageSetup(): base(){ }
  
  public PageSetup(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PageSetup(DXO16DCD.PageSetup openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   paperSize, this property is only available in Office 2016 and later.
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
  ///   firstPageNumber, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? FirstPageNumber
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
  ///   blackAndWhite, this property is only available in Office 2016 and later.
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
        _ExistingElement.BlackAndWhite = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.BlackAndWhite = null;
    }
  }
  
  
  /// <summary>
  ///   draft, this property is only available in Office 2016 and later.
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
        _ExistingElement.Draft = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.Draft = null;
    }
  }
  
  
  /// <summary>
  ///   useFirstPageNumber, this property is only available in Office 2016 and later.
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
        _ExistingElement.UseFirstPageNumber = new BooleanValue { Value = (Boolean)value };
      else
        _ExistingElement.UseFirstPageNumber = null;
    }
  }
  
  
  /// <summary>
  ///   horizontalDpi, this property is only available in Office 2016 and later.
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
  ///   verticalDpi, this property is only available in Office 2016 and later.
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
  ///   copies, this property is only available in Office 2016 and later.
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
