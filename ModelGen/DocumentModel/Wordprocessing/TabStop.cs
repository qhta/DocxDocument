namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single custom tab stop defined within a set of paragraph properties in a document. A tab stop location shall always be measured relative to the leading edge of the paragraph in which it is used (that is, the left edge for a left-to-right paragraph, and the right edge for a right-to-left paragraph).
/// </summary>
public partial class TabStop: ModelElement<DXW.TabStop>
{
  public TabStop(): base(){ }
  
  public TabStop(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TabStop(DXW.TabStop openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Tab Stop Position
  /// </summary>
  [DataMember]
  public Int32? Position
  {
    get
    {
      return _Element?.Position?.Value;
    }
    set
    {
      _ExistingElement.Position = value;
    }
  }
  
}
