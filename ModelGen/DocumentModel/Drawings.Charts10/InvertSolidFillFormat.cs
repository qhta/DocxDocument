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
      var element = _Element?.GetFirstChild<DXO10DC.ShapeProperties>();
      if (element != null)
        return ShapePropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DC.ShapeProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShapePropertiesConverter.CreateOpenXmlElement<DXO10DC.ShapeProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
