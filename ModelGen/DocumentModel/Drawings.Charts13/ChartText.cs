namespace DocumentModel.Drawings.Charts13;


/// <summary>
///   Defines the ChartText Class.
/// </summary>
public partial class ChartText: ModelElement<DXO13DC.ChartText>
{
  public ChartText(): base(){ }
  
  public ChartText(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ChartText(DXO13DC.ChartText openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   String Reference.
  /// </summary>
  [DataMember]
  public DMDC.StringReference? StringReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StringReference>();
      if (element != null)
        return StringReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StringReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringReferenceConverter.CreateOpenXmlElement<DXDC.StringReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Rich Text.
  /// </summary>
  [DataMember]
  public DMDC.RichText? RichText
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.RichText>();
      if (element != null)
        return RichTextConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.RichText>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = RichTextConverter.CreateOpenXmlElement<DXDC.RichText>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   String Literal.
  /// </summary>
  [DataMember]
  public DMDC.StringLiteral? StringLiteral
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.StringLiteral>();
      if (element != null)
        return StringLiteralConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.StringLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = StringLiteralConverter.CreateOpenXmlElement<DXDC.StringLiteral>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
