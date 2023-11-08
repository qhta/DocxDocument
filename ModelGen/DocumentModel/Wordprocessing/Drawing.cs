namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies that a DrawingML object is located at this position in the run’s contents. The layout properties of this DrawingML object are specified using the WordprocessingML Drawing syntax (§20.4).
/// </summary>
public partial class Drawing: ModelElement<DXW.Drawing>
{
  public Drawing(): base(){ }
  
  public Drawing(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Drawing(DXW.Drawing openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Drawing Element Anchor.
  /// </summary>
  [DataMember]
  public DMDW.Anchor? Anchor
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.Anchor>();
      if (element != null)
        return AnchorConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.Anchor>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AnchorConverter.CreateOpenXmlElement<DXDW.Anchor>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Inline Drawing Object.
  /// </summary>
  [DataMember]
  public DMDW.Inline? Inline
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDW.Inline>();
      if (element != null)
        return InlineConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDW.Inline>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = InlineConverter.CreateOpenXmlElement<DXDW.Inline>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
