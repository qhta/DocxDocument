namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies a single list item within the parent combo box structured document tag. Each list item shall be displayed in the list displayed for the nearest ancestor structured document tag (if a user interface is present).
/// </summary>
public partial class ListItem: ModelElement<DXW.ListItem>
{
  public ListItem(): base(){ }
  
  public ListItem(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public ListItem(DXW.ListItem openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   List Entry Display Text
  /// </summary>
  [DataMember]
  public String? DisplayText
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.DisplayText);
    }
    set
    {
      _ExistingElement.DisplayText = StringValueConverter.CreateStringValue(value);
    }
  }
  
  
  /// <summary>
  ///   List Entry Value
  /// </summary>
  [DataMember]
  public String? Value
  {
    get
    {
      return StringValueConverter.GetValue(_Element?.Value);
    }
    set
    {
      _ExistingElement.Value = StringValueConverter.CreateStringValue(value);
    }
  }
  
}
