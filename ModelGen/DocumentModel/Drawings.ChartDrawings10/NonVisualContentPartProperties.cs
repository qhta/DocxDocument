namespace DocumentModel.Drawings.ChartDrawings10;


/// <summary>
///   Defines the NonVisualContentPartProperties Class.
/// </summary>
public partial class NonVisualContentPartProperties: ModelElement<DXO10DCD.NonVisualContentPartProperties>
{
  public NonVisualContentPartProperties(): base(){ }
  
  public NonVisualContentPartProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public NonVisualContentPartProperties(DXO10DCD.NonVisualContentPartProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   NonVisualDrawingProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.NonVisualDrawingProperties? NonVisualDrawingProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD10.NonVisualDrawingProperties,DXO10DCD.NonVisualDrawingProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD10.NonVisualDrawingProperties,DXO10DCD.NonVisualDrawingProperties>(value);
    }
  }
  
  
  /// <summary>
  ///   NonVisualInkContentPartProperties.
  /// </summary>
  [DataMember]
  public DMDCD10.NonVisualInkContentPartProperties? NonVisualInkContentPartProperties
  {
    get
    {
      return _Element?.GetObject<DMDCD10.NonVisualInkContentPartProperties,DXO10DCD.NonVisualInkContentPartProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDCD10.NonVisualInkContentPartProperties,DXO10DCD.NonVisualInkContentPartProperties>(value);
    }
  }
  
}
