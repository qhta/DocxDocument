namespace DocumentModel.Drawings.SketchyShapes;


/// <summary>
///   Defines the LineSketchStyleProperties Class.
/// </summary>
public partial class LineSketchStyleProperties: ModelElement<DXO21DSS.LineSketchStyleProperties>
{
  public LineSketchStyleProperties(): base(){ }
  
  public LineSketchStyleProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public LineSketchStyleProperties(DXO21DSS.LineSketchStyleProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   sd, this property is only available in Office 2021 and later.
  /// </summary>
  [DataMember]
  public UInt32? Sd
  {
    get
    {
      return _Element?.Sd?.Value;
    }
    set
    {
      _ExistingElement.Sd = value;
    }
  }
  
  [DataMember]
  public DMD.CustomGeometry? CustomGeometry
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.CustomGeometry>();
      if (element != null)
        return CustomGeometryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.CustomGeometry>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = CustomGeometryConverter.CreateOpenXmlElement<DXD.CustomGeometry>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMD.PresetGeometry? PresetGeometry
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.PresetGeometry>();
      if (element != null)
        return PresetGeometryConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.PresetGeometry>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = PresetGeometryConverter.CreateOpenXmlElement<DXD.PresetGeometry>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDSS.LineSketchTypeProperties? LineSketchTypeProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DSS.LineSketchTypeProperties>();
      if (element != null)
        return LineSketchTypePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.LineSketchTypeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchTypePropertiesConverter.CreateOpenXmlElement<DXO21DSS.LineSketchTypeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDSS.LineSketchSeed? LineSketchSeed
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DSS.LineSketchSeed>();
      if (element != null)
        return LineSketchSeedConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.LineSketchSeed>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = LineSketchSeedConverter.CreateOpenXmlElement<DXO21DSS.LineSketchSeed>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  [DataMember]
  public DMDSS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXO21DSS.OfficeArtExtensionList>();
      if (element != null)
        return OfficeArtExtensionListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO21DSS.OfficeArtExtensionList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = OfficeArtExtensionListConverter.CreateOpenXmlElement<DXO21DSS.OfficeArtExtensionList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
