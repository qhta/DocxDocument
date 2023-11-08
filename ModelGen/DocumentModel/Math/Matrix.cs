namespace DocumentModel.Math;


/// <summary>
///   Matrix Function.
/// </summary>
public partial class Matrix: ModelElement<DXM.Matrix>
{
  public Matrix(): base(){ }
  
  public Matrix(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public Matrix(DXM.Matrix openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Properties.
  /// </summary>
  [DataMember]
  public DMM.MatrixProperties? MatrixProperties
  {
    get
    {
      var element = _Element?.GetFirstChild<DXM.MatrixProperties>();
      if (element != null)
        return MatrixPropertiesConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.MatrixProperties>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = MatrixPropertiesConverter.CreateOpenXmlElement<DXM.MatrixProperties>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
}
