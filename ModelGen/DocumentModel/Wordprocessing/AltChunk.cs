namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the AltChunk Class.
/// </summary>
public partial class AltChunk: ModelElement<DXW.AltChunk>
{
  public AltChunk(): base(){ }
  
  public AltChunk(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public AltChunk(DXW.AltChunk openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Relationship to Part
  /// </summary>
  [DataMember]
  public String? Id
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Id);
    }
    set
    {
      _ExistingElement.Id = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   External Content Import Properties.
  /// </summary>
  [DataMember]
  public DMW.AltChunkProperties? AltChunkProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.AltChunkProperties>();
      if (element != null)
        return AltChunkPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.AltChunkProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AltChunkPropertiesConverter.CreateOpenXmlElement<DXW.AltChunkProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
