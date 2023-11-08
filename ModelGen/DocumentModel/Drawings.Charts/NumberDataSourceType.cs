namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberDataSourceType Class.
/// </summary>
public partial class NumberDataSourceType: ModelElement<DXDC.NumberDataSourceType>
{
  public NumberDataSourceType(): base(){ }
  
  public NumberDataSourceType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDataSourceType(DXDC.NumberDataSourceType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Number Reference.
  /// </summary>
  [DataMember]
  public DMDC.NumberReference? NumberReference
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumberReference>();
      if (element != null)
        return NumberReferenceConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberReference>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberReferenceConverter.CreateOpenXmlElement<DXDC.NumberReference>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Number Literal.
  /// </summary>
  [DataMember]
  public DMDC.NumberLiteral? NumberLiteral
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.NumberLiteral>();
      if (element != null)
        return NumberLiteralConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.NumberLiteral>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NumberLiteralConverter.CreateOpenXmlElement<DXDC.NumberLiteral>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
