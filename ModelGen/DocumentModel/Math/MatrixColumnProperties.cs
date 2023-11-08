namespace DocumentModel.Math;


/// <summary>
///   Matrix Column Properties.
/// </summary>
public partial class MatrixColumnProperties: ModelElement<DXM.MatrixColumnProperties>
{
  public MatrixColumnProperties(): base(){ }
  
  public MatrixColumnProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public MatrixColumnProperties(DXM.MatrixColumnProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Matrix Column Count.
  /// </summary>
  [DataMember]
  public Int64? MatrixColumnCount
  {
    get
    {
      return SimpleValueConverter.GetValue(_Element?.GetFirstChild<DXM.MatrixColumnCount>()?.Val);
    }
    set
    {
      SimpleValueConverter.SetValue<DXM.MatrixColumnCount,System.Int64>(openXmlElement, value);
    }
  }
  
  
  /// <summary>
  ///   Matrix Column Justification.
  /// </summary>
  [DataMember]
  public DMM.HorizontalAlignmentKind? MatrixColumnJustification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>(_ExistingElement.GetFirstChild<DXM.MatrixColumnJustification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXM.MatrixColumnJustification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>(itemElement, (DMM.HorizontalAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXM.MatrixColumnJustification, DocumentFormat.OpenXml.Math.HorizontalAlignmentValues, DMM.HorizontalAlignmentKind>((DMM.HorizontalAlignmentKind)value));
    }
  }
  
}
