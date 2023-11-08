namespace DocumentModel.Drawings.Diagrams;


/// <summary>
///   Algorithm.
/// </summary>
public partial class Algorithm: ModelElement<DXDDD.Algorithm>
{
  public Algorithm(): base(){ }
  
  public Algorithm(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Algorithm(DXDDD.Algorithm openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Revision Number
  /// </summary>
  [DataMember]
  public UInt32? Revision
  {
    get
    {
      return _Element?.Revision?.Value;
    }
    set
    {
      _ExistingElement.Revision = value;
    }
  }
  
  [DataMember]
  public DMDD.ExtensionList? ExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDDD.ExtensionList>();
      if (element != null)
        return ExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDDD.ExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ExtensionListConverter.CreateOpenXmlElement<DXDDD.ExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
