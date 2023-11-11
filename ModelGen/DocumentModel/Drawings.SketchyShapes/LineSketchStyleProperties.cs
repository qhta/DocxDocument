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
      return _Element?.GetObject<DMD.CustomGeometry,DXD.CustomGeometry>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.CustomGeometry,DXD.CustomGeometry>(value);
    }
  }
  
  [DataMember]
  public DMD.PresetGeometry? PresetGeometry
  {
    get
    {
      return _Element?.GetObject<DMD.PresetGeometry,DXD.PresetGeometry>();
    }
    set
    {
      _ExistingElement.SetObject<DMD.PresetGeometry,DXD.PresetGeometry>(value);
    }
  }
  
  [DataMember]
  public DMDSS.LineSketchTypeProperties? LineSketchTypeProperties
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchTypeProperties,DXO21DSS.LineSketchTypeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchTypeProperties,DXO21DSS.LineSketchTypeProperties>(value);
    }
  }
  
  [DataMember]
  public DMDSS.LineSketchSeed? LineSketchSeed
  {
    get
    {
      return _Element?.GetObject<DMDSS.LineSketchSeed,DXO21DSS.LineSketchSeed>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.LineSketchSeed,DXO21DSS.LineSketchSeed>(value);
    }
  }
  
  [DataMember]
  public DMDSS.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDSS.OfficeArtExtensionList,DXO21DSS.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDSS.OfficeArtExtensionList,DXO21DSS.OfficeArtExtensionList>(value);
    }
  }
  
}
