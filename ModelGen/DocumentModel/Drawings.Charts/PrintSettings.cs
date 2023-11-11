namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettings: ModelElement<DXDC.PrintSettings>
{
  public PrintSettings(): base(){ }
  
  public PrintSettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintSettings(DXDC.PrintSettings openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Header and Footer.
  /// </summary>
  [DataMember]
  public DMDC.HeaderFooter? HeaderFooter
  {
    get
    {
      return _Element?.GetObject<DMDC.HeaderFooter,DXDC.HeaderFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.HeaderFooter,DXDC.HeaderFooter>(value);
    }
  }
  
  
  /// <summary>
  ///   Page Margins.
  /// </summary>
  [DataMember]
  public DMDC.PageMargins? PageMargins
  {
    get
    {
      return _Element?.GetObject<DMDC.PageMargins,DXDC.PageMargins>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PageMargins,DXDC.PageMargins>(value);
    }
  }
  
  
  /// <summary>
  ///   Page Setup.
  /// </summary>
  [DataMember]
  public DMDC.PageSetup? PageSetup
  {
    get
    {
      return _Element?.GetObject<DMDC.PageSetup,DXDC.PageSetup>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.PageSetup,DXDC.PageSetup>(value);
    }
  }
  
  
  /// <summary>
  ///   Legacy Drawing for Headers and Footers.
  /// </summary>
  [DataMember]
  public DMDC.LegacyDrawingHeaderFooter? LegacyDrawingHeaderFooter
  {
    get
    {
      return _Element?.GetObject<DMDC.LegacyDrawingHeaderFooter,DXDC.LegacyDrawingHeaderFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC.LegacyDrawingHeaderFooter,DXDC.LegacyDrawingHeaderFooter>(value);
    }
  }
  
}
