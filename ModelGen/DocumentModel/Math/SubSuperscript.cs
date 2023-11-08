namespace DocumentModel.Math;


/// <summary>
///   Sub-Superscript Function.
/// </summary>
public partial class SubSuperscript: ModelElement<DXM.SubSuperscript>
{
  public SubSuperscript(): base(){ }
  
  public SubSuperscript(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SubSuperscript(DXM.SubSuperscript openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Sub-Superscript Properties.
  /// </summary>
  [DataMember]
  public DMM.SubSuperscriptProperties? SubSuperscriptProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SubSuperscriptProperties>();
      if (element != null)
        return SubSuperscriptPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SubSuperscriptProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubSuperscriptPropertiesConverter.CreateOpenXmlElement<DXM.SubSuperscriptProperties>(value);
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
  ///   Subscript (Sub-Superscript).
  /// </summary>
  [DataMember]
  public DMM.SubArgument? SubArgument
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.SubArgument>();
      if (element != null)
        return SubArgumentConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.SubArgument>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SubArgumentConverter.CreateOpenXmlElement<DXM.SubArgument>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   Superscript (Sub-Superscript function).
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
