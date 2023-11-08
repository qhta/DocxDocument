namespace DocumentModel.Drawings;


/// <summary>
///   This element specifies when a preset geometric shape should be used instead of a custom geometric shape. The generating application should be able to render all preset geometries enumerated in the ST_ShapeType list.
/// </summary>
public partial class PresetGeometry: ModelElement<DXD.PresetGeometry>
{
  public PresetGeometry(): base(){ }
  
  public PresetGeometry(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public PresetGeometry(DXD.PresetGeometry openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   List of Shape Adjust Values.
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
