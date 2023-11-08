namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the PaperSource Class.
/// </summary>
public partial class PaperSource: ModelElement<DXW.PaperSource>
{
  public PaperSource(): base(){ }
  
  public PaperSource(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PaperSource(DXW.PaperSource openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   First Page Printer Tray Code
  /// </summary>
  [DataMember]
  public UInt16? First
  {
    get
    {
      return _Element?.First?.Value;
    }
    set
    {
      _ExistingElement.First = value;
    }
  }
  
  
  /// <summary>
  ///   Non-First Page Printer Tray Code
  /// </summary>
  [DataMember]
  public UInt16? Other
  {
    get
    {
      return _Element?.Other?.Value;
    }
    set
    {
      _ExistingElement.Other = value;
    }
  }
  
}
