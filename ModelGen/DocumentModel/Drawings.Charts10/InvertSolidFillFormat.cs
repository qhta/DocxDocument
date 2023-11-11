namespace DocumentModel.Drawings.Charts10;


/// <summary>
///   Defines the InvertSolidFillFormat Class.
/// </summary>
public partial class InvertSolidFillFormat: ModelElement<DXO10DC.InvertSolidFillFormat>
{
  public InvertSolidFillFormat(): base(){ }
  
  public InvertSolidFillFormat(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public InvertSolidFillFormat(DXO10DC.InvertSolidFillFormat openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   ShapeProperties.
  /// </summary>
  [DataMember]
  public DMDC10.ShapeProperties? ShapeProperties
  {
    get
    {
      return _Element?.GetObject<DMDC10.ShapeProperties,DXO10DC.ShapeProperties>();
    }
    set
    {
      _ExistingElement.SetObject<DMDC10.ShapeProperties,DXO10DC.ShapeProperties>(value);
    }
  }
  
}
