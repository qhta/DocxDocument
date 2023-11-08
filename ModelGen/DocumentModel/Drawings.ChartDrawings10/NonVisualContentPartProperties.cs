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
      var element = _Element?.GetFirstChild<DXO10DCD.NonVisualDrawingProperties>();
      if (element != null)
        return NonVisualDrawingPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DCD.NonVisualDrawingProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualDrawingPropertiesConverter.CreateOpenXmlElement<DXO10DCD.NonVisualDrawingProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
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
      var element = _Element?.GetFirstChild<DXO10DCD.NonVisualInkContentPartProperties>();
      if (element != null)
        return NonVisualInkContentPartPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXO10DCD.NonVisualInkContentPartProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NonVisualInkContentPartPropertiesConverter.CreateOpenXmlElement<DXO10DCD.NonVisualInkContentPartProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
