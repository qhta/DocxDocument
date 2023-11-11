namespace DocumentModel.Wordprocessing;


/// <summary>
///   This element specifies the set of table properties which shall be applied to all regions within a table which match the conditional formatting type specified on the parent tblStylePr element. These properties are applied in the order specified via the style hierarchy.
/// </summary>
public partial class TableStyleConditionalFormattingTableProperties: ModelElement<DXW.TableStyleConditionalFormattingTableProperties>
{
  public TableStyleConditionalFormattingTableProperties(): base(){ }
  
  public TableStyleConditionalFormattingTableProperties(DX.OpenXmlElement openXmlElement): base(openXmlElement) { }
  
  public TableStyleConditionalFormattingTableProperties(DXW.TableStyleConditionalFormattingTableProperties openXmlElement): base(openXmlElement) { }
  
  
  /// <summary>
  ///   TableJustification.
  /// </summary>
  [DataMember]
  public DMW.TableRowAlignmentKind? TableJustification
  {
    get
    {
      return EnumValueConverter.GetValue<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(_ExistingElement.GetFirstChild<DXW.TableJustification>()?.Val?.Value);
    }
    set
    {
      var itemElement = _ExistingElement.GetFirstChild<DXW.TableJustification>();
      if (itemElement != null)
      {
        if (value != null)
          EnumValueConverter.UpdateOpenXmlElement<DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>(itemElement, (DMW.TableRowAlignmentKind)value);
        else
          itemElement.Remove();
      }
      else
      if (value != null)
        _ExistingElement.AddChild(EnumValueConverter.CreateOpenXmlElement<DXW.TableJustification, DocumentFormat.OpenXml.Wordprocessing.TableRowAlignmentValues, DMW.TableRowAlignmentKind>((DMW.TableRowAlignmentKind)value));
    }
  }
  
  
  /// <summary>
  ///   TableCellSpacing.
  /// </summary>
  [DataMember]
  public DMW.TableCellSpacing? TableCellSpacing
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellSpacing,DXW.TableCellSpacing>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellSpacing,DXW.TableCellSpacing>(value);
    }
  }
  
  
  /// <summary>
  ///   TableIndentation.
  /// </summary>
  [DataMember]
  public DMW.TableIndentation? TableIndentation
  {
    get
    {
      return _Element?.GetObject<DMW.TableIndentation,DXW.TableIndentation>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableIndentation,DXW.TableIndentation>(value);
    }
  }
  
  
  /// <summary>
  ///   TableBorders.
  /// </summary>
  [DataMember]
  public DMW.TableBorders? TableBorders
  {
    get
    {
      return _Element?.GetObject<DMW.TableBorders,DXW.TableBorders>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableBorders,DXW.TableBorders>(value);
    }
  }
  
  
  /// <summary>
  ///   Shading.
  /// </summary>
  [DataMember]
  public DMW.Shading? Shading
  {
    get
    {
      return _Element?.GetObject<DMW.Shading,DXW.Shading>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.Shading,DXW.Shading>(value);
    }
  }
  
  
  /// <summary>
  ///   TableCellMarginDefault.
  /// </summary>
  [DataMember]
  public DMW.TableCellMarginDefault? TableCellMarginDefault
  {
    get
    {
      return _Element?.GetObject<DMW.TableCellMarginDefault,DXW.TableCellMarginDefault>();
    }
    set
    {
      _ExistingElement.SetObject<DMW.TableCellMarginDefault,DXW.TableCellMarginDefault>(value);
    }
  }
  
}
