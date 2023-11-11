namespace DocumentModel.Drawings.Office;


/// <summary>
///   Defines the Shape Class.
/// </summary>
public partial class Shape: ModelElement<DXOD.Shape>
{
  public Shape(): base(){ }
  
  public Shape(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Shape(DXOD.Shape openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   modelId, this property is only available in Office 2010 and later.
  /// </summary>
  [DataMember]
  public String? ModelId
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.ModelId);
    }
    set
    {
      _ExistingElement.ModelId = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   ShapeNonVisualProperties.
  /// </summary>
  [DataMember]
  public DMDO.ShapeNonVisualProperties? ShapeNonVisualProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.ShapeNonVisualProperties,DXOD.ShapeNonVisualProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.ShapeNonVisualProperties,DXOD.ShapeNonVisualProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDO.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDO.ShapeProperties,DXOD.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.ShapeProperties,DXOD.ShapeProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   ShapeStyle.
  /// </summary>
  [DataMember]
  public DMDO.ShapeStyle? ShapeStyle
  {
    get
    {
      return _Element?.GetObject<DMDO.ShapeStyle,DXOD.ShapeStyle>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.ShapeStyle,DXOD.ShapeStyle>(value);
    }
  }
  
  
  /// <summary>
  ///   TextBody.
  /// </summary>
  [DataMember]
  public DMDO.TextBody? TextBody
  {
    get
    {
      return _Element?.GetObject<DMDO.TextBody,DXOD.TextBody>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.TextBody,DXOD.TextBody>(value);
    }
  }
  
  
  /// <summary>
  ///   Transform2D.
  /// </summary>
  [DataMember]
  public DMDO.Transform2D? Transform2D
  {
    get
    {
      return _Element?.GetObject<DMDO.Transform2D,DXOD.Transform2D>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.Transform2D,DXOD.Transform2D>(value);
    }
  }
  
  
  /// <summary>
  ///   OfficeArtExtensionList.
  /// </summary>
  [DataMember]
  public DMDO.OfficeArtExtensionList? OfficeArtExtensionList
  {
    get
    {
      return _Element?.GetObject<DMDO.OfficeArtExtensionList,DXOD.OfficeArtExtensionList>();
    }
    set
    {
      _ExistingElement.SetObject<DMDO.OfficeArtExtensionList,DXOD.OfficeArtExtensionList>(value);
    }
  }
  
}
