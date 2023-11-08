namespace DocumentModel.Drawings.Charts;


/// <summary>
///   Defines the NumberDataType Class.
/// </summary>
public partial class NumberDataType: ModelElement<DXDC.NumberDataType>
{
  public NumberDataType(): base(){ }
  
  public NumberDataType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NumberDataType(DXDC.NumberDataType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Format Code.
  /// </summary>
  [DataMember]
  public DMDC.FormatCode? FormatCode
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.FormatCode>();
      if (element != null)
        return FormatCodeConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.FormatCode>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = FormatCodeConverter.CreateOpenXmlElement<DXDC.FormatCode>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Point Count.
  /// </summary>
  [DataMember]
  public DMDC.PointCount? PointCount
  {
    get
    {
      var element = _Element?.GetFirstChild<DXDC.PointCount>();
      if (element != null)
        return PointCountConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXDC.PointCount>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PointCountConverter.CreateOpenXmlElement<DXDC.PointCount>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
