namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table cell properties which shall be applied to the table. These properties are not conditional and shall always be applied (although they are applied before all conditional formatting properties).
/// </summary>
public partial class StyleTableCellProperties: ModelElement<DXW.StyleTableCellProperties>
{
  public StyleTableCellProperties(): base(){ }
  
  public StyleTableCellProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public StyleTableCellProperties(DXW.StyleTableCellProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.Shading>();
      if (element != null)
        return ShadingConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.Shading>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = ShadingConverter.CreateOpenXmlElement<DXW.Shading>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   NoWrap.
  /// </summary>
  [DataMember]
  public DMW.NoWrap? NoWrap
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.NoWrap>();
      if (element != null)
        return NoWrapConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.NoWrap>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = NoWrapConverter.CreateOpenXmlElement<DXW.NoWrap>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableCellMargin.
  /// </summary>
  [DataMember]
  public DMW.TableCellMargin? TableCellMargin
  {
    get
    {
      var element = _Element?.GetFirstChild<DXW.TableCellMargin>();
      if (element != null)
        return TableCellMarginConverter.CreateModelElement(element);
      return null;
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellMargin>();
      if (itemElement != null)
        itemElement.Remove();
      if (value != null)
      {
        itemElement = TableCellMarginConverter.CreateOpenXmlElement<DXW.TableCellMargin>(value);
        if (itemElement != null)
          _ExistingElement.AddChild(itemElement);
      }
    }
  }
  
  
  /// <summary>
  ///   TableCellVerticalAlignment.
  /// </summary>
  [DataMember]
  public DMW.TableVerticalAlignmentKind? TableCellVerticalAlignment
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(_ExistingElement.GetFirstChild<DXW.TableCellVerticalAlignment>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableCellVerticalAlignment>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>(itemElement, (DMW.TableVerticalAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableCellVerticalAlignment, DocumentFormat.OpenXml.Wordprocessing.TableVerticalAlignmentValues, DMW.TableVerticalAlignmentKind>((DMW.TableVerticalAlignmentKind)value));
    }
  }
  
}
