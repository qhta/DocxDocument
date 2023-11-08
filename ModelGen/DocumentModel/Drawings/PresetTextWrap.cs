namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used to transform a piece of text. This operation is known formally as a text warp. The generating application should be able to render all preset geometries enumerated in the ST_TextShapeType list.
/// </summary>
public partial class PresetTextWrap: ModelElement<DXD.PresetTextWrap>
{
  public PresetTextWrap(): base(){ }
  
  public PresetTextWrap(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresetTextWrap(DXD.PresetTextWrap openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Adjust Value List.
  /// </summary>
  [DataMember]
  public DMD.AdjustValueList? AdjustValueList
  {
    get
    {
      var element = _Element?.GetFirstChild<DXD.AdjustValueList>();
      if (element != null)
        return AdjustValueListConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXD.AdjustValueList>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = AdjustValueListConverter.CreateOpenXmlElement<DXD.AdjustValueList>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
