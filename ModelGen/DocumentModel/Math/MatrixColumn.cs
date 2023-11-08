namespace DocumentModel.Math;


/// <summary>
///   Matrix Column.
/// </summary>
public partial class MatrixColumn: ModelElement<DXM.MatrixColumn>
{
  public MatrixColumn(): base(){ }
  
  public MatrixColumn(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixColumn(DXM.MatrixColumn openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Column Properties.
  /// </summary>
  [DataMember]
  public DMM.MatrixColumnProperties? MatrixColumnProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.MatrixColumnProperties>();
      if (element != null)
        return MatrixColumnPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.MatrixColumnProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixColumnPropertiesConverter.CreateOpenXmlElement<DXM.MatrixColumnProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
