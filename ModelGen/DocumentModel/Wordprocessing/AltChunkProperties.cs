namespace DocumentModel.Wordprocessing;


/// <summary>
///   External Content Import Properties.
/// </summary>
public partial class AltChunkProperties: ModelElement<DXW.AltChunkProperties>
{
  public AltChunkProperties(): base(){ }
  
  public AltChunkProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AltChunkProperties(DXW.AltChunkProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Keep Source Formatting on Import.
  /// </summary>
  [DataMember]
  public DMW.MatchSource? MatchSource
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.MatchSource>();
      if (element != null)
        return MatchSourceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.MatchSource>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatchSourceConverter.CreateOpenXmlElement<DXW.MatchSource>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
