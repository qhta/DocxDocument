namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the PrintSettings Class.
/// </summary>
public partial class PrintSettings: ModelElement<DXO16DCD.PrintSettings>
{
  public PrintSettings(): base(){ }
  
  public PrintSettings(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PrintSettings(DXO16DCD.PrintSettings openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   HeaderFooter.
  /// </summary>
  [DataMember]
  public DMDCD16.HeaderFooter? HeaderFooter
  {
    get
    {
      return _Element?.GetObject<DMDCD16.HeaderFooter,DXO16DCD.HeaderFooter>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.HeaderFooter,DXO16DCD.HeaderFooter>(value);
    }
  }
  
  
  /// <summary>
  ///   PageMargins.
  /// </summary>
  [DataMember]
  public DMDCD16.PageMargins? PageMargins
  {
    get
    {
      return _Element?.GetObject<DMDCD16.PageMargins,DXO16DCD.PageMargins>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.PageMargins,DXO16DCD.PageMargins>(value);
    }
  }
  
  
  /// <summary>
  ///   PageSetup.
  /// </summary>
  [DataMember]
  public DMDCD16.PageSetup? PageSetup
  {
    get
    {
      return _Element?.GetObject<DMDCD16.PageSetup,DXO16DCD.PageSetup>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.PageSetup,DXO16DCD.PageSetup>(value);
    }
  }
  
}
