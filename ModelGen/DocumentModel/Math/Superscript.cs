namespace DocumentModel.Math;


/// <summary>
///   Superscript Function.
/// </summary>
public partial class Superscript: ModelElement<DXM.Superscript>
{
  public Superscript(): base(){ }
  
  public Superscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Superscript(DXM.Superscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SuperscriptProperties? SuperscriptProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SuperscriptProperties>();
      if (element != null)
        return SuperscriptPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SuperscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperscriptPropertiesConverter.CreateOpenXmlElement<DXM.SuperscriptProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Base.
  /// </summary>
  [DataMember]
  public DMM.Base? Base
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.Base>();
      if (element != null)
        return BaseConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.Base>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = BaseConverter.CreateOpenXmlElement<DXM.Base>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Superscript (Superscript function).
  /// </summary>
  [DataMember]
  public DMM.SuperArgument? SuperArgument
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SuperArgument>();
      if (element != null)
        return SuperArgumentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SuperArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SuperArgumentConverter.CreateOpenXmlElement<DXM.SuperArgument>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
