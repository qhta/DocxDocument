namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the indentation which shall be added before the leading edge of the current table in the document (the left edge in a left-to-right table, and the right edge in a right-to-left table). This indentation should shift the table into the text margin by the specified amount.
/// </summary>
public partial class TableIndentation: ModelElement<DXW.TableIndentation>
{
  public TableIndentation(): base(){ }
  
  public TableIndentation(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableIndentation(DXW.TableIndentation openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   w
  /// </summary>
  [DataMember]
  public Int32? Width
  {
    get
    {
      return _Element?.Width?.Value;
    }
    set
    {
      _ExistingElement.Width = value;
    }
  }
  
}
