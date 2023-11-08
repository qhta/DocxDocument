namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the presence of a structured document tag around one or more block-level structures (paragraphs, tables, etc.). The two child elements of this element shall be used to specify the properties and content of the current structured document tag via the sdtPr and sdtContent elements, respectively.
/// </summary>
public partial class SdtRunRuby: ModelElement<DXW.SdtRunRuby>
{
  public SdtRunRuby(): base(){ }
  
  public SdtRunRuby(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public SdtRunRuby(DXW.SdtRunRuby openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   SdtContentRunRuby.
  /// </summary>
  [DataMember]
  public DMW.SdtContentRunRuby? SdtContentRunRuby
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SdtContentRunRuby>();
      if (element != null)
        return SdtContentRunRubyConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SdtContentRunRuby>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtContentRunRubyConverter.CreateOpenXmlElement<DXW.SdtContentRunRuby>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.SdtProperties? SdtProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SdtProperties>();
      if (element != null)
        return SdtPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SdtProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtPropertiesConverter.CreateOpenXmlElement<DXW.SdtProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMW.SdtEndCharProperties? SdtEndCharProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.SdtEndCharProperties>();
      if (element != null)
        return SdtEndCharPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.SdtEndCharProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = SdtEndCharPropertiesConverter.CreateOpenXmlElement<DXW.SdtEndCharProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
