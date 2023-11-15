namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the fonts which shall be used to display the text contents of this run. Within a single run, there can be up to four types of font slot which shall each be allowed to use a unique font:
/// </summary>
public partial class RunFonts: ModelElement<DXW.RunFonts>
{
  public RunFonts(): base(){ }
  
  public RunFonts(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public RunFonts(DXW.RunFonts openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ASCII Font
  /// </summary>
  [DataMember]
  public String? Ascii
  {
    get => _Element?.Ascii;
    set => _ExistingElement.Ascii = value;
  }
  
  
  /// <summary>
  ///   High ANSI Font
  /// </summary>
  [DataMember]
  public String? HighAnsi
  {
    get => _Element?.HighAnsi;
    set => _ExistingElement.HighAnsi = value;
  }
  
  
  /// <summary>
  ///   East Asian Font
  /// </summary>
  [DataMember]
  public String? EastAsia
  {
    get => _Element?.EastAsia;
    set => _ExistingElement.EastAsia = value;
  }
  
  
  /// <summary>
  ///   Complex Script Font
  /// </summary>
  [DataMember]
  public String? ComplexScript
  {
    get => _Element?.ComplexScript;
    set => _ExistingElement.ComplexScript = value;
  }
  
}
