namespace DocumentModel.Wordprocessing;


/// <summary>
///   Defines the TableWidthType Class.
/// </summary>
public partial class TableWidthType: ModelElement<DXW.TableWidthType>
{
  public TableWidthType(): base(){ }
  
  public TableWidthType(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableWidthType(DXW.TableWidthType openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Table Width Value
  /// </summary>
  [DataMember]
  public String? Width
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Width);
    }
    set
    {
      _ExistingElement.Width = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
