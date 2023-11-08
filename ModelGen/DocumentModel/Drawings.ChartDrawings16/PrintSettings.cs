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
      var element = _Element?.GetFirstChild<DXO16DCD.HeaderFooter>();
      if (element != null)
        return HeaderFooterConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.HeaderFooter>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = HeaderFooterConverter.CreateOpenXmlElement<DXO16DCD.HeaderFooter>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.PageMargins>();
      if (element != null)
        return PageMarginsConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.PageMargins>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageMarginsConverter.CreateOpenXmlElement<DXO16DCD.PageMargins>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO16DCD.PageSetup>();
      if (element != null)
        return PageSetupConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO16DCD.PageSetup>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PageSetupConverter.CreateOpenXmlElement<DXO16DCD.PageSetup>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
