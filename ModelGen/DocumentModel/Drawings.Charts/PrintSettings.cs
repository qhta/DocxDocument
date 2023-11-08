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
      var element = _Element?.GetFirstChild<DXDC.HeaderFooter>();
      if (element != null)
        return HeaderFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.HeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderFooterConverter.CreateOpenXmlElement<DXDC.HeaderFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.PageMargins>();
      if (element != null)
        return PageMarginsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PageMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageMarginsConverter.CreateOpenXmlElement<DXDC.PageMargins>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.PageSetup>();
      if (element != null)
        return PageSetupConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PageSetup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageSetupConverter.CreateOpenXmlElement<DXDC.PageSetup>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXDC.LegacyDrawingHeaderFooter>();
      if (element != null)
        return LegacyDrawingHeaderFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.LegacyDrawingHeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LegacyDrawingHeaderFooterConverter.CreateOpenXmlElement<DXDC.LegacyDrawingHeaderFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
