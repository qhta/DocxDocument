namespace DocumentModel.Drawings.ChartDrawings16;


/// <summary>
///   Defines the FormatOverride Class.
/// </summary>
public partial class FormatOverride: ModelElement<DXO16DCD.FormatOverride>
{
  public FormatOverride(): base(){ }
  
  public FormatOverride(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public FormatOverride(DXO16DCD.FormatOverride openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   idx, this property is only available in Office 2016 and later.
  /// </summary>
  [DataMember]
  public UInt32? Idx
  {
    get
    {
      return _Element?.Idx?.Value;
    }
    set
    {
      _ExistingElement.Idx = value;
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDCD16.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ShapeProperties,DXO16DCD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   ExtensionList.
  /// </summary>
  [DataMember]
  public DMDCD16.ExtensionList? ExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD16.ExtensionList,DXO16DCD.ExtensionList>(value);
    }
  }
  
}
